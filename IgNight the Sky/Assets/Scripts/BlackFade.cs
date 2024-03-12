using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackFade : MonoBehaviour
{
    public Image blackOutSquare;


    public bool fadeOutBool = false;

    public Image blackOutSquare2;

    public AudioSource audio;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //blackOutSquare.GetComponent<Image>().color.a = 0;
        // blackOutSquare.enabled = false;
        // blackOutSquare2.enabled = false;
        //Debug.Log("balckout" + blackOutSquare.enabled);

    }
    public void setFadeBoolTrue() {
        
        // blackOutSquare.enabled = true;
        // blackOutSquare2.enabled = true;
        // anim.SetBool("fadeBool", true);
        // fadeOutBool = true;

        // if (fadeOutBool) {
        //     StartCoroutine(FadeBlackOutSquare());
        // }
        // if (fadeOutBool = false) {
        //     StartCoroutine(FadeBlackOutSquare(false));
        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, int fadeSpeed = 5) {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack) {
            while (blackOutSquare.GetComponent<Image>().color.a < 1) {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
        }
        }
        else {
            while (blackOutSquare.GetComponent<Image>().color.a > 0) {
                fadeAmount = objectColor.a - (fadeSpeed* Time.deltaTime);
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;

            }
        }
    }

}
