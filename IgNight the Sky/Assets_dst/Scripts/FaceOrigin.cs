using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* A script to make sure that the constellation face the origin */
public class FaceOrigin : MonoBehaviour
{
    [SerializeField] private Transform originTransform;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>().LookAt(originTransform);
    }
}
