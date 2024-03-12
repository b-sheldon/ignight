using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCardBuild : MonoBehaviour
{

    [SerializeField] private GameObject AriesCard;
    [SerializeField] private GameObject VirgoCard;
    [SerializeField] private GameObject LeoCard;
    [SerializeField] private GameObject CancerCard;
    [SerializeField] private GameObject GeminiCard;
    [SerializeField] private GameObject TaurusCard;

    [SerializeField] private GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
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
            CardMove(AriesCard);
            if (ConstellationData.instance.activePedestals.Contains(AriesCard)) {
                ConstellationData.instance.activePedestals.Remove(AriesCard);
            }

        }
        else if (other.CompareTag("VirgoCard")) {
            VirgoCard.SetActive(true);
            VirgoCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            CardMove(VirgoCard);
            if (ConstellationData.instance.activePedestals.Contains(VirgoCard)) {
                ConstellationData.instance.activePedestals.Remove(VirgoCard);
            }
        }
        else if (other.CompareTag("LeoCard")) {
            LeoCard.SetActive(true);
            LeoCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            CardMove(LeoCard);
            if (ConstellationData.instance.activePedestals.Contains(LeoCard)) {
                ConstellationData.instance.activePedestals.Remove(LeoCard);
            }
        }
        else if (other.CompareTag("CancerCard")) {
            CancerCard.SetActive(true);
            CancerCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            CardMove(CancerCard);
            if (ConstellationData.instance.activePedestals.Contains(CancerCard)) {
                ConstellationData.instance.activePedestals.Remove(CancerCard);
            }
        }
        else if (other.CompareTag("GeminiCard")) {
            GeminiCard.SetActive(true);
            GeminiCard.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            CardMove(GeminiCard);
            if (ConstellationData.instance.activePedestals.Contains(GeminiCard)) {
            ConstellationData.instance.activePedestals.Remove(GeminiCard);
            }
        }
        else if (other.CompareTag("TaurusCard")) {
            TaurusCard.SetActive(true);
            TaurusCard.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            CardMove(TaurusCard);
            if (ConstellationData.instance.activePedestals.Contains(TaurusCard)) {
                ConstellationData.instance.activePedestals.Remove(TaurusCard);
            }
        }

    }

    public void CardMove(GameObject card) {
        Transform cardTransform = card.transform;  

        float offset = 0.5f;  

        Vector3 newPosition = hand.transform.position + new Vector3(offset, 0, 0);
        cardTransform.position = newPosition;   
    }


   



    // Update is called once per frame
    void Update()
    {
        
    }
}

