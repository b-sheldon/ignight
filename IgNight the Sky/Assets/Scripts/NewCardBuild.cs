using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCardBuild : MonoBehaviour
{
    [SerializeField] private AudioSource cardSound;
    [SerializeField] private AudioSource sparkleSound;

    [SerializeField] private GameObject AriesCard;
    [SerializeField] private GameObject VirgoCard;
    [SerializeField] private GameObject LeoCard;
    [SerializeField] private GameObject CancerCard;
    [SerializeField] private GameObject GeminiCard;
    [SerializeField] private GameObject TaurusCard;

    [SerializeField] private GameObject hand;
    public GameObject centerEyeAnchor;

    [SerializeField] private GameObject AriesSkyLocation;
    [SerializeField] private GameObject VirgoSkyLocation;
    [SerializeField] private GameObject LeoSkyLocation;
    [SerializeField] private GameObject CancerSkyLocation;
    [SerializeField] private GameObject GeminiSkyLocation;
    [SerializeField] private GameObject TaurusSkyLocation;

    [SerializeField] private GameObject[] constellationTrails;

    private bool move = false;
    [SerializeField] private Transform destination;

    public float speed = 10.0f;  // Speed of movement
    // Start is called before the first frame update
    void Start()
    {
        centerEyeAnchor.transform.position = new Vector3(centerEyeAnchor.transform.position.x, centerEyeAnchor.transform.position.y + 1.0f, centerEyeAnchor.transform.position.z);
        AriesCard.SetActive(false);
        VirgoCard.SetActive(false);
        LeoCard.SetActive(false);
        CancerCard.SetActive(false);
        GeminiCard.SetActive(false);
        TaurusCard.SetActive(false);
    }
    public void CreateCard(Collider other) {


        if (other.CompareTag("AriesCard")) {
            AriesCard.SetActive(true);
            AriesCard.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            move = true;
            CardMove(AriesCard, AriesSkyLocation);
            constellationTrails[0].SetActive(false);
            constellationTrails[0].SetActive(true);
            //AriesCard.transform.position = AriesSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(AriesCard)) {
                ConstellationData.instance.activePedestals.Remove(AriesCard);
                PedestalEffects.instance.DeactivatePedestalEffect(AriesCard);
                // Erase Constellation
                ConstellationData.instance.constellationTokenMap[AriesCard].GetComponent<Animator>().SetBool("Draw", false);
                ConstellationData.instance.constellationTokenMap[AriesCard].GetComponent<Animator>().SetBool("Erase", true);
            }

        }
        else if (other.CompareTag("VirgoCard")) {
            VirgoCard.SetActive(true);
            VirgoCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            move = true;
            CardMove(VirgoCard, VirgoSkyLocation);
            constellationTrails[1].SetActive(false);
            constellationTrails[1].SetActive(true);
            //VirgoCard.transform.position = VirgoSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(VirgoCard)) {
                ConstellationData.instance.activePedestals.Remove(VirgoCard);
                PedestalEffects.instance.DeactivatePedestalEffect(VirgoCard);
                // Erase Constellation
                ConstellationData.instance.constellationTokenMap[VirgoCard].GetComponent<Animator>().SetBool("Draw", false);
                ConstellationData.instance.constellationTokenMap[VirgoCard].GetComponent<Animator>().SetBool("Erase", true);
            }
        }
        else if (other.CompareTag("LeoCard")) {
            LeoCard.SetActive(true);
            LeoCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            LeoCard.transform.rotation = Quaternion.Euler(0.161304414f,276.313538f,358.542389f);
            move = true;
            CardMove(LeoCard, LeoSkyLocation);
            constellationTrails[2].SetActive(false);
            constellationTrails[2].SetActive(true);
            //LeoCard.transform.position = LeoSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(LeoCard)) {
                ConstellationData.instance.activePedestals.Remove(LeoCard);
                PedestalEffects.instance.DeactivatePedestalEffect(LeoCard);
                // Erase Constellation
                ConstellationData.instance.constellationTokenMap[LeoCard].GetComponent<Animator>().SetBool("Draw", false);
                ConstellationData.instance.constellationTokenMap[LeoCard].GetComponent<Animator>().SetBool("Erase", true);
            }
        }
        else if (other.CompareTag("CancerCard")) {
            CancerCard.SetActive(true);
            CancerCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            move = true;
            CardMove(CancerCard, CancerSkyLocation);
            constellationTrails[3].SetActive(false);
            constellationTrails[3].SetActive(true);
            //CancerCard.transform.position = CancerSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(CancerCard)) {
                ConstellationData.instance.activePedestals.Remove(CancerCard);
                PedestalEffects.instance.DeactivatePedestalEffect(CancerCard);
                // Erase Constellation
                ConstellationData.instance.constellationTokenMap[CancerCard].GetComponent<Animator>().SetBool("Draw", false);
                ConstellationData.instance.constellationTokenMap[CancerCard].GetComponent<Animator>().SetBool("Erase", true);
            }
        }
        else if (other.CompareTag("GeminiCard")) {
            GeminiCard.SetActive(true);
            GeminiCard.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            GeminiCard.transform.rotation = Quaternion.Euler(4.33585215f,356.651611f,82.9141312f);
            move = true;
            CardMove(GeminiCard, GeminiSkyLocation);
            constellationTrails[4].SetActive(false);
            constellationTrails[4].SetActive(true);
            //GeminiCard.transform.position = GeminiSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(GeminiCard)) {
            ConstellationData.instance.activePedestals.Remove(GeminiCard);
            PedestalEffects.instance.DeactivatePedestalEffect(GeminiCard);
            //Erase Constellation
            ConstellationData.instance.constellationTokenMap[GeminiCard].GetComponent<Animator>().SetBool("Draw", false);
            ConstellationData.instance.constellationTokenMap[GeminiCard].GetComponent<Animator>().SetBool("Erase", true);
            }
        }
        else if (other.CompareTag("TaurusCard")) {
            TaurusCard.SetActive(true);
            TaurusCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            TaurusCard.transform.rotation = Quaternion.Euler(82.3587189f,346.858215f,101.888084f);
            move = true;
            CardMove(TaurusCard, TaurusSkyLocation);
            constellationTrails[5].SetActive(false);
            constellationTrails[5].SetActive(true);
            //TaurusCard.transform.position = TaurusSkyLocation.transform.position;
            if (ConstellationData.instance.activePedestals.Contains(TaurusCard)) {
                ConstellationData.instance.activePedestals.Remove(TaurusCard);
                PedestalEffects.instance.DeactivatePedestalEffect(TaurusCard);
                // Erase Constellation
                ConstellationData.instance.constellationTokenMap[TaurusCard].GetComponent<Animator>().SetBool("Draw", false);
                ConstellationData.instance.constellationTokenMap[TaurusCard].GetComponent<Animator>().SetBool("Erase", true);
            }
        }

    }

    public void CardMove(GameObject card, GameObject cardPosition) {
        cardSound.Play();
        sparkleSound.Play();
        Transform cardTransform = card.transform;  
        Transform cardSkyPositionTransform = cardPosition.transform;

        destination.localScale = cardTransform.localScale;
        destination.rotation = cardTransform.rotation;
        float offset = 0.5f;  

        //original move to hand
        // Vector3 newPosition = hand.transform.position + new Vector3(offset, 0, 0);
        // cardTransform.position = newPosition; 

        //move to skyposition
        Vector3 skyLocation = cardPosition.transform.position;
        cardTransform.position = skyLocation;
        //move = true;

        //New movement
        //Card position in the sky
        //Vector3 cardPos = cardSkyPositionTransform.position;
        //Set as that position
        //cardTransform.position = cardPos;
        //cardTransform = cardSkyPositionTransform;

        //set move true 
        // move = true;

        // if (move) {
        //     var step =  speed * Time.deltaTime;

        //     cardTransform.position = Vector3.MoveTowards(cardTransform.position, destination.position, step);
        //     cardTransform.localScale = Vector3.MoveTowards(cardTransform.localScale, destination.localScale, step / 4);
        //     cardTransform.rotation = Quaternion.Lerp(cardTransform.rotation, destination.rotation, step * 2);

        //     // Check if the position is approximately at the endpoint.
        //     if (Vector3.Distance(cardTransform.position, destination.position) < 0.01f && Quaternion.Angle(cardTransform.rotation, destination.rotation) < 1.0f && Vector3.Distance(cardTransform.localScale, destination.localScale) < 0.01f)
        //     {
                
        //         // Stop moving the constellation
        //         move = false;
        //     }


          
        // }

        StartCoroutine(ContinuousMove(cardTransform, destination));

    }
   
    IEnumerator ContinuousMove(Transform cardTransform, Transform destination)
    {
        move = true;

        while (move)
        {
            var step = speed * Time.deltaTime;

            cardTransform.position = Vector3.MoveTowards(cardTransform.position, destination.position, step);
            cardTransform.localScale = Vector3.MoveTowards(cardTransform.localScale, destination.localScale, step / 4);
            cardTransform.rotation = Quaternion.Lerp(cardTransform.rotation, destination.rotation, step * 2);

            // Check if the position is approximately at the endpoint.
            if (Vector3.Distance(cardTransform.position, destination.position) < 0.01f &&
                Quaternion.Angle(cardTransform.rotation, destination.rotation) < 1.0f &&
                Vector3.Distance(cardTransform.localScale, destination.localScale) < 0.01f)
            {
                // Stop moving
                move = false;
            }

            yield return null;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

