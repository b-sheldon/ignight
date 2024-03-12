using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservatoryUp : MonoBehaviour
{
    public Animator animator;

    public void ObservationUp() {
        animator.SetBool("everythingUpPressed", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
