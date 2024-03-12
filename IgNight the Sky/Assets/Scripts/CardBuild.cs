using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBuild : MonoBehaviour
{

    [SerializeField] private GameObject AriesCard;
    [SerializeField] private GameObject PiscesCard;
    [SerializeField] private GameObject AquariusCard;
    [SerializeField] private GameObject CapricornusCard;
    [SerializeField] private GameObject SagittariusCard;
    [SerializeField] private GameObject ScorpiusCard;
    [SerializeField] private GameObject LibraCard;
    [SerializeField] private GameObject VirgoCard;
    [SerializeField] private GameObject LeoCard;
    [SerializeField] private GameObject CancerCard;
    [SerializeField] private GameObject GeminiCard;
    [SerializeField] private GameObject TaurusCard;

    [SerializeField] private GameObject pointedConstellation;

    [SerializeField] private GameObject currentCard;

    [SerializeField] private GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        AriesCard.SetActive(false);
        PiscesCard.SetActive(false);
        AquariusCard.SetActive(false);
        CapricornusCard.SetActive(false);
        SagittariusCard.SetActive(false);
        ScorpiusCard.SetActive(false);
        LibraCard.SetActive(false);
        VirgoCard.SetActive(false);
        LeoCard.SetActive(false);
        CancerCard.SetActive(false);
        GeminiCard.SetActive(false);
        TaurusCard.SetActive(false);
        currentCard.SetActive(false);
    }

    //   public void CreateCard(Collider other) {
    //     if (other.CompareTag("Constellation 1")) {
    //         currentCard.SetActive(false);
    //         card.SetActive(true);
    //         currentCard = card;
    //         currentCard.SetActive(true);
    //     }
    //     if (other.CompareTag("Constellation 2")) {
    //         currentCard.SetActive(false);
    //         card2.SetActive(true);
    //         currentCard = card2;
    //         currentCard.SetActive(true);
    //     }
    // } 

    public void CreateCard(Collider other) {
    // Assuming 'currentCard' is the card that is currently active
    if (currentCard != null) {
        currentCard.SetActive(false);
    }

    if (other.CompareTag("AriesCard")) {
        currentCard = AriesCard;
    }
    else if (other.CompareTag("AquariusCard")) {
        currentCard = AquariusCard;
    }
     else if (other.CompareTag("PiscesCard")) {
        currentCard = PiscesCard;
    }
     else if (other.CompareTag("CapricornusCard")) {
        currentCard = CapricornusCard;
    }
     else if (other.CompareTag("SagittariusCard")) {
        currentCard = SagittariusCard;
    }
     else if (other.CompareTag("ScorpiusCard")) {
        currentCard = ScorpiusCard;
    }
     else if (other.CompareTag("LibraCard")) {
        currentCard = LibraCard;
    }
     else if (other.CompareTag("VirgoCard")) {
        currentCard = VirgoCard;
    }
     else if (other.CompareTag("LeoCard")) {
        currentCard = LeoCard;
    }
     else if (other.CompareTag("CancerCard")) {
        currentCard = CancerCard;
    }
     else if (other.CompareTag("GeminiCard")) {
        currentCard = GeminiCard;
    }
     else if (other.CompareTag("TaurusCard")) {
        currentCard = TaurusCard;
    }


    if (currentCard != null) {
        currentCard.SetActive(true);
        Transform cardTransform = currentCard.transform;  

        float offset = 0.5f;  

        Vector3 newPosition = hand.transform.position + new Vector3(offset, 0, 0);
        cardTransform.position = newPosition;      
    }
}
   



    // Update is called once per frame
    void Update()
    {
        
    }
}
