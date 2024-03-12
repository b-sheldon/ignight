using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a Singleton Script that manages all of the data related to Constellations (Stars, Cards, Tokens, etc.) */
public class ConstellationData : MonoBehaviour
{
    public static ConstellationData instance;       // Singleton instance
    [SerializeField] private GameObject gazeInteractor; // the gaze interactor
    public GameObject[] constellations;             // array of constellations, should be constant at runtime
    public GameObject[] constellationCards;         // array of constellation tokens (tracking which constellations have been discovered)
                                                    // should be the same size as constellations, with tokens put in the same order as constellations
    [SerializeField] private Animator endSceneAnimator; // the animator for the end scene
    [SerializeField] private GameObject endGameModelVFX; // the vfx for all 3D Models
    [SerializeField] private AudioSource[] endGameAudio; // the audio for the end game

    [SerializeField] private GameObject[] ringAnimators; // the animators for the rings
    public HashSet<GameObject> activePedestals;      // list of active pedestals with constellations
    public Dictionary<GameObject, GameObject> constellationTokenMap;
    public Dictionary<GameObject, bool> constellationGazeInteractableMap;
    private bool endGameTriggered = false;  // flag to check if end game has been triggered before
    private bool drawAllConstellations = false; // flag to initiate drawing all constellations
    private IEnumerator fadeSound; // the fade sound coroutine

    public GameObject meteor1;     //meteor showers

 

    void Awake()
    {
        // Ensure that there is only one instance of this script
        if (instance != null && instance != this) Destroy(gameObject);
        else instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // instantiate Set of Seen Constellations
        activePedestals = new HashSet<GameObject>();

        // instantiate Map of Constellations to Tokens
        constellationTokenMap = new Dictionary<GameObject, GameObject>();
        for (int i = 0; i < constellationCards.Length; i++) {
            constellationTokenMap.Add(constellationCards[i], constellations[i]);
        }
        constellationGazeInteractableMap = new Dictionary<GameObject, bool>();
        for (int i = 0; i < constellations.Length; i++) {
            constellationGazeInteractableMap.Add(constellations[i], true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if all constellations have been seen, and endGame has not already been triggered, trigger the end game sequence
        if (!endGameTriggered && activePedestals.Count == constellations.Length) {
            TriggerEndGame();
        }

        // if end game has been triggered and player inspects another constellation, untrigger end game
        if (drawAllConstellations && activePedestals.Count < constellations.Length && endGameTriggered) {
            UnTriggerEndGame();
        }
    }

    private void TriggerEndGame() {

        // trigger end game
        endSceneAnimator.SetBool("End", true);
        endSceneAnimator.SetBool("StopEnd", false);

        // set flags to true
        drawAllConstellations = true;
        endGameTriggered = true;

        // Turn off the Gaze Interactor
        gazeInteractor.SetActive(false);

        //meteor shower
        Invoke("MeteorShower", 7f);

    }
    private void UnTriggerEndGame() {
        // untrigger end game
        endSceneAnimator.SetBool("End", false);
        endSceneAnimator.SetBool("StopEnd", true);

        // set drawConstellations to false
        drawAllConstellations = false;
        
        // Turn on the Gaze Interactor
        gazeInteractor.SetActive(true);

        // Show all of the Constellation Cards
        ShowConstellationCards();

        // Hide the VFX for 3D Models
        HideEndVFX();

        // HideConstellations()
        HideConstellations();
    }
    private void DrawConstellations() {
        // Show all constellations
        foreach (GameObject constellation in constellations) {
            constellation.GetComponent<Animator>().SetBool("Draw", true);
            constellation.GetComponent<Animator>().SetBool("Erase", false);
        }
    }
    private void DrawEndVFX() {
        // Show the VFX for 3D Models
        endGameModelVFX.SetActive(true);
    }
    private void HideConstellations() {
        // Hide all constellations
        foreach (GameObject constellation in constellations) {
            constellation.GetComponent<Animator>().SetBool("Draw", false);
            constellation.GetComponent<Animator>().SetBool("Erase", true);
        }
    }
    private void HideConstellationCards() {
        // Hide all of the Constellation Cards
        foreach (GameObject card in constellationCards) {
            card.SetActive(false);
        }
    }
    private void HideEndVFX() {
        // Hide the VFX for 3D Models
        endGameModelVFX.SetActive(false);
    }
    private void ShowConstellationCards() {
        // Show all of the Constellation Cards
        foreach (GameObject card in constellationCards) {
            card.SetActive(true);
        }
    }
    private void PlayAmbientAudio() {
        // Play the Ambient Audio
        endGameAudio[0].Play();
    }
    private void FadeAmbientAudio() {
        // Fade the Ambient Audio
        fadeSound = FadeAudio.FadeOut(endGameAudio[0], 0.2f);
        StartCoroutine(fadeSound);
    }
    private void StopAmbientAudio() {
        // Stop the Ambient Audio (called sequentially after FadeAmbientAudio())
        StopCoroutine(fadeSound);
        endGameAudio[0].Stop();
    }

    private void FadeEndAudio() {
        // Fade the Ambient Audio
        fadeSound = FadeAudio.FadeOut(endGameAudio[3], 0.05f);
        StartCoroutine(fadeSound);
    }
    private void PlayBuildUpAudio() {
        // Play the Build Up Audio (Length 13.848s)
        endGameAudio[1].Play();
    }

    private void PlayExplosionAudio() {
        // Play the End Explosion Audio
        endGameAudio[2].Play();
    }

    private void PlayPostEndAudio() {
        // Play the Post End New Ambient Sound
        endGameAudio[3].Play();
    }

    private void MeteorShower() {
        meteor1.SetActive(true);

    }

    // Functions to light up the rings and moons on the platform
    private void lightRing1() {
        ringAnimators[0].GetComponent<Animator>().SetBool("Light", true);
    }
    private void lightRing2() {
        ringAnimators[1].GetComponent<Animator>().SetBool("Light", true);
    }
    private void lightRing3() {
        ringAnimators[2].GetComponent<Animator>().SetBool("Light", true);
    }
    private void lightRing4() {
        ringAnimators[3].GetComponent<Animator>().SetBool("Light", true);
    }
    private void lightMoons() {
        ringAnimators[4].GetComponent<Animator>().SetBool("Light", true);
    }
}
