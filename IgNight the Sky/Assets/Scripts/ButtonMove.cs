using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public Animator animator;
    public AudioSource audio;

    public void ButtonMoveAnimation() {
        animator.SetBool("buttonMove", true);
        audio.Play();
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
