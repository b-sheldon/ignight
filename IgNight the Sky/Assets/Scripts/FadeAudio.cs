 /* This Script was taken from the Unity Forums, and is used to fade out audio
    https://forum.unity.com/threads/fade-out-audio-source.335031/   */

using UnityEngine;
using System.Collections;

public static class FadeAudio {
 
    public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }
 
}