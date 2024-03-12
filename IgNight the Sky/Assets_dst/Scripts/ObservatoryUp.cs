using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservatoryUp : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to play an animation
    public void PlayAnimation()
    {
    
        animator.SetBool("buttonPressed", true);

    }
}
