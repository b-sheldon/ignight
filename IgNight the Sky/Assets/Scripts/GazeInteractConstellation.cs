using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* This is a script that manages the mechanics of animating constellations when the camera looks at them, and it should be put on
   the gaze interactor which contains a collider that tracks the main camera angle */
public class GazeInteractConstellation : MonoBehaviour
{
    private GameObject constellation;       // Constellation that is being looked at
    private Animator animator;              // Animator of constellation being looked at
    

    /* Detect if a player looks at a constellation */
    private void OnTriggerEnter(Collider collider)
    {  
        constellation = collider.gameObject.transform.parent.gameObject;
        // If player looks at a constellation, trigger the constellation to draw
        if (collider.tag == "Constellation" && ConstellationData.instance.constellationGazeInteractableMap[constellation]) {
            animator = constellation.GetComponent<Animator>();
            if (animator != null) {
                animator.SetBool("Draw", true);
                animator.SetBool("Erase", false);
            }
        }
    }

    /* Detect if a player stops looking at a constellation */
    private void OnTriggerExit(Collider collider)
    {
        constellation = collider.gameObject.transform.parent.gameObject;
        // If the player stops looking at a constellation (moves camera away), trigger the constellation to erase
        if (collider.tag == "Constellation" && ConstellationData.instance.constellationGazeInteractableMap[constellation]) {
            animator = constellation.GetComponent<Animator>();
            if (animator != null) {
                animator.SetBool("Erase", true);
                animator.SetBool("Draw", false);
            }
        }
    }
}
