using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioPlayer;
    public AudioClip[] audioClip;

    public static SoundManager instance = null;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioPlayer = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardPlay()
    {
        //for (int i = 0; i < audioPlayer.Length; i++)
        //{
        //    if (audioPlayer[i].GetComponent<AudioSource>().clip.name.Contains("cardaccept"))
        //    {
        //        audioPlayer[i].clip = audioPlayer[i].GetComponent<AudioSource>().clip;
        //        audioPlayer[i].Play();
        //        break;
        //    }
        //}
        for (int i = 0; i < audioClip.Length; i++)
        {
            if (audioClip[i].name.Contains("cardaccept"))
            {
                audioPlayer.clip = audioClip[i];
                audioPlayer.Play();
                break;
            }
        }
    }

    public void WeaponShootPlay()
    {
        for (int i = 0; i < audioClip.Length; i++)
        {
            if (audioClip[i].name.Contains("weaponfire"))
            {
                audioPlayer.clip = audioClip[i];
                audioPlayer.Play();
                break;
            }
            //print(audioPlayer[i].GetComponent<AudioSource>().clip.name);
            //if (audioPlayer[i].GetComponent<AudioSource>().clip.name.Contains("weaponfire"))
            //{
            //    audioPlayer[i].clip = audioPlayer[i].GetComponent<AudioSource>().clip;
            //    audioPlayer[i].Play();
            //    break;
            //}
        }
    }
}
