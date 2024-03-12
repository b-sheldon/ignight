using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* A script to move a GameObject towards another location over time after moving it vertically upwards */
public class MoveToLocation : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public float speed = 1.0f;  // Speed of movement
    private bool move = false; // Flag to check if the Constellation Card should move
    private bool finishedMovingUp = false; // Flag to check if the Constellation Card has finished moving up

    private float upHeight = 3.0f; // How high the Constellation Card should move up before moving towards the final location
    private bool calculateUpHeight = true; // Flag to check if the upHeight has been calculated

    // Update is called once per frame
    void Update()
    {
        if (move) {
            var step =  speed * Time.deltaTime; // calculate distance
            if (calculateUpHeight) {
                upHeight = transform.position.y + 2.5f;
                calculateUpHeight = false;
            }
            // Move the Constellation Card straight up
            if (!finishedMovingUp && transform.position.y < upHeight) {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, upHeight + 4.0f, transform.position.z), step);
                if (transform.position.y >= upHeight) {
                    finishedMovingUp = true;
                }
            }
            else {
                // Move the constellation towards the final location.
                transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
                transform.localScale = Vector3.MoveTowards(transform.localScale, destination.localScale, step / 2);
                transform.rotation = Quaternion.Lerp(transform.rotation, destination.rotation, step * 2);

                // Check if the position is approximately at the endpoint.
                if (Vector3.Distance(transform.position, destination.position) < 0.01f && Quaternion.Angle(transform.rotation, destination.rotation) < 1.0f && Vector3.Distance(transform.localScale, destination.localScale) < 0.01f)
                {
                    
                    // Stop moving the constellation
                    move = false;
                    finishedMovingUp = false;
                    calculateUpHeight = true;

                    // Add the Constellation to the list of active pedestals
                    ConstellationData.instance.activePedestals.Add(gameObject);

                    // Activate the Pedestal Token
                    PedestalEffects.instance.ActivatePedestalEffect(gameObject);

                    // Draw the Constellation
                    ConstellationData.instance.constellationTokenMap[gameObject].GetComponent<Animator>().SetBool("Draw", true);
                    ConstellationData.instance.constellationTokenMap[gameObject].GetComponent<Animator>().SetBool("Erase", false);
                    ConstellationData.instance.constellationGazeInteractableMap[ConstellationData.instance.constellationTokenMap[gameObject]] = false;
                }
            }
        }
    }

    /* Set move flag to true */
    public void SetMoveTrue() {
        move = true;
    }
}
