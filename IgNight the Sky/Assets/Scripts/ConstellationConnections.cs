using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Contains Functions to Show or Hide Constellation Connections */
public class ConstellationConnections : MonoBehaviour
{
    /* Show All Constellation Connections in this Constellation */
    public void ShowConstellationConnections() 
    {
        foreach (Transform child in transform) {
            if (child.gameObject.tag == "Connection") {
                child.gameObject.SetActive(true);
            }
        }
    }

    /* Hide All Constellation Connections in this Constellation */
    public void HideConstellationConnections()
    {
        foreach (Transform child in transform) {
            if (child.gameObject.tag == "Connection") {
                child.gameObject.SetActive(false);
            }
        }
    }
}
