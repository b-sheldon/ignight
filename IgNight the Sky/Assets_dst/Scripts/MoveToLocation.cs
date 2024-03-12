using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* A script to move a GameObject towards another location over time */
public class MoveToLocation : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public float speed = 1.0f;  // Speed of movement
    private bool move = false;
    private bool finishedMovingUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move) {
            var step =  speed * Time.deltaTime; // calculate distance

            // Move the Constellation Card straight up
            if (!finishedMovingUp && transform.position.y < 3.0f) {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 5.0f, transform.position.z), step);
                if (transform.position.y >= 3.0f) {
                    finishedMovingUp = true;
                }
            }
            else {
                // Move the constellation towards the final location.
                transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
                transform.localScale = Vector3.MoveTowards(transform.localScale, destination.localScale, step);
                transform.rotation = Quaternion.MoveTowards(transform.rotation, destination.rotation, step);
            }

            // Check if the position is approximately at the endpoint.
            if (Vector3.Distance(transform.position, destination.position) < 0.01f && Vector3.Distance(transform.localScale, destination.localScale) < 0.01f && Quaternion.Angle(transform.rotation, destination.rotation) < 1.0f)
            {
                // Stop moving the constellation
                move = false;
                finishedMovingUp = false;

                // Add the Constellation to the list of active pedestals
                ConstellationData.instance.activePedestals.Add(gameObject);

                // Activate the Pedestal Token
                PedestalEffects.instance.ActivatePedestalEffect(gameObject);
                Debug.Log("Pedestal Activated for " + gameObject.tag);
            }
        }
    }

    /* Set move flag to true */
    public void SetMoveTrue() {
        move = true;
    }
}
