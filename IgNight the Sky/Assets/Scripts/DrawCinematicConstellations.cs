using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCinematicConstellations : MonoBehaviour
{
    [SerializeField] private Animator[] constellations;
    
    void DrawConstellations() {
        foreach (Animator constellation in constellations) {
            constellation.SetBool("Draw", true);
        }
    }
}
