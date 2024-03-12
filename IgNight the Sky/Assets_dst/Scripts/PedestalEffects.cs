using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalEffects : MonoBehaviour
{
    public static PedestalEffects instance;       // Singleton instance
    [SerializeField] private GameObject AriesPedestalEffects;
    [SerializeField] private GameObject VirgoPedestalEffects;
    [SerializeField] private GameObject LeoPedestalEffects;
    [SerializeField] private GameObject CancerPedestalEffects;
    [SerializeField] private GameObject GeminiPedestalEffects;
    [SerializeField] private GameObject TaurusPedestalEffects;

    void Awake()
    {
        // Ensure that there is only one instance of this script
        if (instance != null && instance != this) Destroy(gameObject);
        else instance = this;
    }

    public void ActivatePedestalEffect(GameObject constellation)
    {
        GameObject pedestalEffect = null;
        if (constellation.CompareTag("AriesCard"))
        {
            pedestalEffect = AriesPedestalEffects;
        }
        else if (constellation.CompareTag("VirgoCard"))
        {
            pedestalEffect = VirgoPedestalEffects;
        }
        else if (constellation.CompareTag("LeoCard"))
        {
            pedestalEffect = LeoPedestalEffects;
        }
        else if (constellation.CompareTag("CancerCard"))
        {
            pedestalEffect = CancerPedestalEffects;
        }
        else if (constellation.CompareTag("GeminiCard"))
        {
            pedestalEffect = GeminiPedestalEffects;
        }
        else if (constellation.CompareTag("TaurusCard"))
        {
            pedestalEffect = TaurusPedestalEffects;
        }

        if (pedestalEffect != null)
        {
            pedestalEffect.SetActive(true);
            pedestalEffect.GetComponent<ParticleSystem>().Play();
        }
    }

    public void DeactivatePedestalEffect(GameObject constellation)
    {
        GameObject pedestalEffect = null;
        if (constellation.CompareTag("AriesCard"))
        {
            pedestalEffect = AriesPedestalEffects;
        }
        else if (constellation.CompareTag("VirgoCard"))
        {
            pedestalEffect = VirgoPedestalEffects;
        }
        else if (constellation.CompareTag("LeoCard"))
        {
            pedestalEffect = LeoPedestalEffects;
        }
        else if (constellation.CompareTag("CancerCard"))
        {
            pedestalEffect = CancerPedestalEffects;
        }
        else if (constellation.CompareTag("GeminiCard"))
        {
            pedestalEffect = GeminiPedestalEffects;
        }
        else if (constellation.CompareTag("TaurusCard"))
        {
            pedestalEffect = TaurusPedestalEffects;
        }

        if (pedestalEffect != null)
        {
            pedestalEffect.SetActive(false);
            pedestalEffect.GetComponent<ParticleSystem>().Clear();
            pedestalEffect.GetComponent<ParticleSystem>().Stop();
        }
    }
}
