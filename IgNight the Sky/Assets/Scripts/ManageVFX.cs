using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[RequireComponent(typeof(VisualEffect))]

/* Enable and Disable a Visual Effect */
public class ManageVFX : MonoBehaviour
{
    public void EnableVFX()
    {
        GetComponent<VisualEffect>().enabled = true;
    }
    public void DisableVFX()
    {
        GetComponent<VisualEffect>().enabled = false;
    }
}
