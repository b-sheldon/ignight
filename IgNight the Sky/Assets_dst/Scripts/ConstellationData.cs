using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a Singleton Script that manages all of the data related to Constellations (Stars, Cards, Tokens, etc.) */
public class ConstellationData : MonoBehaviour
{
    public static ConstellationData instance;       // Singleton instance
    [SerializeField] private GameObject gazeInteractor; // the gaze interactor
    public GameObject[] constellations;             // array of constellations, should be constant at runtime
    public GameObject[] constellationTokens;        // array of constellation tokens (tracking which constellations have been discovered)
                                                    // should be the same size as constellations, with tokens put in the same order as constellations
    public HashSet<GameObject> activePedestals;      // list of active pedestals with constellations
    public Dictionary<GameObject, GameObject> constellationTokenMap;
    private bool endGameTriggered = false;  // flag to check if end game has been triggered before
    private bool drawAllConstellations = false; // flag to initiate drawing all constellations
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
        for (int i = 0; i < constellationTokens.Length; i++) {
            constellationTokenMap.Add(constellations[i], constellationTokens[i]);
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
        Debug.Log("All constellations have been seen!");
        // trigger end game
        drawAllConstellations = true;
        endGameTriggered = true;
        // Turn off the Gaze Interactor
        gazeInteractor.SetActive(false);

        // Show all constellations
        foreach (GameObject constellation in constellations) {
            constellation.GetComponent<Animator>().SetBool("Draw", true);
            constellation.GetComponent<Animator>().SetBool("Erase", false);
        }
    }

    private void UnTriggerEndGame() {
        // untrigger end game
        drawAllConstellations = false;
        // Turn on the Gaze Interactor
        gazeInteractor.SetActive(true);
        // Hide all constellations
        foreach (GameObject constellation in constellations) {
            constellation.GetComponent<Animator>().SetBool("Draw", false);
            constellation.GetComponent<Animator>().SetBool("Erase", true);
        }
    }
}
