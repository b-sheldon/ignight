using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Function to Activate a Particle System on a Pedestal */
public class ActivatePedestalPS : MonoBehaviour
{
    [SerializeField] private GameObject pedestalPS;
    
    public void ActivatePS() {
        pedestalPS.SetActive(true);
    }
}
