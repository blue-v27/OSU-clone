using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip hitSound, breakCombo;
    static AudioSource audioSrc;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        hitSound = Resources.Load<AudioClip>("hitSound");
        breakCombo = Resources.Load<AudioClip>("breakCombo");
    }

    // Update is called once per frame
    public static void PlaySound(string clip)
    {
        switch (clip)
        {

            case "hitSound":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "breakCombo":
                audioSrc.PlayOneShot(breakCombo);
                break;
        }
    }
}
