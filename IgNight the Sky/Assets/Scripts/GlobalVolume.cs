using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class GlobalVolume : MonoBehaviour
{
    
    public GameObject objWithVolume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void decreaseThreshold() {
        var volume = objWithVolume.GetComponent<Volume>();
        volume.profile.TryGet(out Bloom bloom);
        bloom.threshold.value = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
