using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Enable and Set Animator Booleans for the Title and Instruction VFX */
public class EnableInstructionVFX : MonoBehaviour
{
    [SerializeField] private GameObject titleVFX;
    [SerializeField] private GameObject instructionVFX;

    public void DrawTitleVFXAnimation() {
        titleVFX.SetActive(true);
        instructionVFX.SetActive(false);
        titleVFX.GetComponent<Animator>().SetBool("Draw", true);
    }
    public void EraseTitleVFXAnimation() {
        titleVFX.GetComponent<Animator>().SetBool("Draw", false);
        titleVFX.GetComponent<Animator>().SetBool("Erase", true);
    }
    public void DrawInstructionVFXAnimation() {
        instructionVFX.SetActive(true);
        titleVFX.SetActive(false);
        instructionVFX.GetComponent<Animator>().SetBool("Draw", true);
    }
}
