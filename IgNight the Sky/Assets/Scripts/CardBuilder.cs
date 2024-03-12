using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardBuilder : MonoBehaviour
{
    [SerializeField] private GameObject card;
    [SerializeField] private GameObject card2;

    [SerializeField] private GameObject pointedConstellation;

     // Start is called before the first frame update
    void Start()
    {
        card.SetActive(false);
        card2.SetActive(false);
    }

    public void CreateCard(Collider other) {
        if (other.CompareTag("Constellation 1")) {
            card.SetActive(true);
        }
        if (other.CompareTag("Constellation 2")) {
            card2.SetActive(true);
        }
        
    } 
   

    public void TransitionTest() {
        SceneManager.LoadScene("test");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
