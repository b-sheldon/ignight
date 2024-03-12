using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToFront : MonoBehaviour
{
    [SerializeField] private Transform frontDestination;
    [SerializeField] private AudioSource testParticle;
    public float speed = 10.0f;  // Speed of movement
    private bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (move) {
            var step =  speed * Time.deltaTime; // calculate distance

            // Move the constellation towards the final location.
            transform.position = Vector3.MoveTowards(transform.position, frontDestination.position, step);
            transform.localScale = Vector3.MoveTowards(transform.localScale, frontDestination.localScale, step / 4);
            transform.rotation = Quaternion.Lerp(transform.rotation, frontDestination.rotation, step * 2);

            // Check if the position is approximately at the endpoint.
            if (Vector3.Distance(transform.position, frontDestination.position) < 0.01f && Quaternion.Angle(transform.rotation, frontDestination.rotation) < 1.0f && Vector3.Distance(transform.localScale, frontDestination.localScale) < 0.01f)
            {
                
                // Stop moving the constellation
                move = false;
            }
            
        }
    }

    /* Set move flag to true */
    public void SetMoveToFrontTrue() {
        move = true;
    }
}
