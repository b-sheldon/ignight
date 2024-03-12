using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalEffects : MonoBehaviour
{
    public static PedestalEffects instance;       // Singleton instance
    /* Pedestal Effects for all 6 Zodiac Symbols */
    [SerializeField] private GameObject AriesPedestalEffects;
    [SerializeField] private GameObject VirgoPedestalEffects;
    [SerializeField] private GameObject LeoPedestalEffects;
    [SerializeField] private GameObject CancerPedestalEffects;
    [SerializeField] private GameObject GeminiPedestalEffects;
    [SerializeField] private GameObject TaurusPedestalEffects;

    /* Text for all 6 Zodiac Symbols */
    [SerializeField] private Animator AriesText;
    [SerializeField] private Animator VirgoText;
    [SerializeField] private Animator LeoText;
    [SerializeField] private Animator CancerText;
    [SerializeField] private Animator GeminiText;
    [SerializeField] private Animator TaurusText;

    /* Platform Constellation for all 6 Zodiac Symbols */
    [SerializeField] private Animator AriesPlatformConstellation;
    [SerializeField] private Animator VirgoPlatformConstellation;
    [SerializeField] private Animator LeoPlatformConstellation;
    [SerializeField] private Animator CancerPlatformConstellation;
    [SerializeField] private Animator GeminiPlatformConstellation;
    [SerializeField] private Animator TaurusPlatformConstellation;

    


    void Awake()
    {
        // Ensure that there is only one instance of this script
        if (instance != null && instance != this) Destroy(gameObject);
        else instance = this;
    }

    void Start()
    {
        // Activate the pedestal effects Game Objects
        AriesPedestalEffects.SetActive(false);
        VirgoPedestalEffects.SetActive(false);
        LeoPedestalEffects.SetActive(false);
        CancerPedestalEffects.SetActive(false);
        GeminiPedestalEffects.SetActive(false);
        TaurusPedestalEffects.SetActive(false);
    }

    /* Activate all pedestal effects, platform constellations, and zodiac names */
    public void ActivatePedestalEffect(GameObject constellation)
    {
        if (constellation.CompareTag("AriesCard")) {
            AriesText.SetBool("Draw", true);
            AriesText.SetBool("Erase", false);
            AriesPlatformConstellation.SetBool("Light", true);
            AriesPlatformConstellation.SetBool("Dark", false);
        }
        else if (constellation.CompareTag("VirgoCard")) {
            VirgoText.SetBool("Draw", true);
            VirgoText.SetBool("Erase", false);
            VirgoPlatformConstellation.SetBool("Light", true);
            VirgoPlatformConstellation.SetBool("Dark", false);
        }
        else if (constellation.CompareTag("LeoCard")) {
            LeoText.SetBool("Draw", true);
            LeoText.SetBool("Erase", false);
            LeoPlatformConstellation.SetBool("Light", true);
            LeoPlatformConstellation.SetBool("Dark", false);
        }
        else if (constellation.CompareTag("CancerCard")) {
            CancerText.SetBool("Draw", true);
            CancerText.SetBool("Erase", false);
            CancerPlatformConstellation.SetBool("Light", true);
            CancerPlatformConstellation.SetBool("Dark", false);
        }
        else if (constellation.CompareTag("GeminiCard")) {
            GeminiText.SetBool("Draw", true);
            GeminiText.SetBool("Erase", false);
            GeminiPlatformConstellation.SetBool("Light", true);
            GeminiPlatformConstellation.SetBool("Dark", false);
        }
        else if (constellation.CompareTag("TaurusCard")) {
            TaurusText.SetBool("Draw", true);
            TaurusText.SetBool("Erase", false);
            TaurusPlatformConstellation.SetBool("Light", true);
            TaurusPlatformConstellation.SetBool("Dark", false);
        }
    }

    /* Deactivate all pedestal effects, platform constellations, and zodiac names */
    public void DeactivatePedestalEffect(GameObject constellation)
    {
        if (constellation.CompareTag("AriesCard")) {
            AriesPedestalEffects.SetActive(false);
            AriesText.SetBool("Draw", false);
            AriesText.SetBool("Erase", true);
            AriesPlatformConstellation.SetBool("Dark", true);
            AriesPlatformConstellation.SetBool("Light", false);
        }
        else if (constellation.CompareTag("VirgoCard")) {
            VirgoPedestalEffects.SetActive(false);
            VirgoText.SetBool("Draw", false);
            VirgoText.SetBool("Erase", true);
            VirgoPlatformConstellation.SetBool("Dark", true);
            VirgoPlatformConstellation.SetBool("Light", false);
        }
        else if (constellation.CompareTag("LeoCard")) {
            LeoPedestalEffects.SetActive(false);
            LeoText.SetBool("Draw", false);
            LeoText.SetBool("Erase", true);
            LeoPlatformConstellation.SetBool("Dark", true);
            LeoPlatformConstellation.SetBool("Light", false);
        }
        else if (constellation.CompareTag("CancerCard")) {
            CancerPedestalEffects.SetActive(false);
            CancerText.SetBool("Draw", false);
            CancerText.SetBool("Erase", true);
            CancerPlatformConstellation.SetBool("Dark", true);
            CancerPlatformConstellation.SetBool("Light", false);
        }
        else if (constellation.CompareTag("GeminiCard")) {
            GeminiPedestalEffects.SetActive(false);
            GeminiText.SetBool("Draw", false);
            GeminiText.SetBool("Erase", true);
            GeminiPlatformConstellation.SetBool("Dark", true);
            GeminiPlatformConstellation.SetBool("Light", false);
        }
        else if (constellation.CompareTag("TaurusCard")) {
            TaurusPedestalEffects.SetActive(false);
            TaurusText.SetBool("Draw", false);
            TaurusText.SetBool("Erase", true);
            TaurusPlatformConstellation.SetBool("Dark", true);
            TaurusPlatformConstellation.SetBool("Light", false);
        }
    }

    /* Deactivate all pedestal effects */
    public void DeactivateAllPedestalEffects()
    {
        AriesPedestalEffects.SetActive(false);
        VirgoPedestalEffects.SetActive(false);
        LeoPedestalEffects.SetActive(false);
        CancerPedestalEffects.SetActive(false);
        GeminiPedestalEffects.SetActive(false);
        TaurusPedestalEffects.SetActive(false);
    }

    /* Activate all pedestal effects */
    public void ActivateAllPedestalEffects()
    {
        AriesPedestalEffects.SetActive(true);
        VirgoPedestalEffects.SetActive(true);
        LeoPedestalEffects.SetActive(true);
        CancerPedestalEffects.SetActive(true);
        GeminiPedestalEffects.SetActive(true);
        TaurusPedestalEffects.SetActive(true);
    }

    /* Activate all Zodiac Names */
    public void ActivateAllText()
    {
        AriesText.SetBool("Draw", false);
        AriesText.SetBool("Erase", true);
        VirgoText.SetBool("Draw", false);
        VirgoText.SetBool("Erase", true);
        LeoText.SetBool("Draw", false);
        LeoText.SetBool("Erase", true);
        CancerText.SetBool("Draw", false);
        CancerText.SetBool("Erase", true);
        GeminiText.SetBool("Draw", false);
        GeminiText.SetBool("Erase", true);
        TaurusText.SetBool("Draw", false);
        TaurusText.SetBool("Erase", true);
    }

    /* Deactivate all Zodiac Names */
    public void DeactivateAllText()
    {
        AriesText.SetBool("Draw", true);
        AriesText.SetBool("Erase", false);
        VirgoText.SetBool("Draw", true);
        VirgoText.SetBool("Erase", false);
        LeoText.SetBool("Draw", true);
        LeoText.SetBool("Erase", false);
        CancerText.SetBool("Draw", true);
        CancerText.SetBool("Erase", false);
        GeminiText.SetBool("Draw", true);
        GeminiText.SetBool("Erase", false);
        TaurusText.SetBool("Draw", true);
        TaurusText.SetBool("Erase", false);
    }


}
