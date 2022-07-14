using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static SoundControl Instance;
    private AudioSource audioSource;
    public AudioClip[] audioClip;


    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();    
    }

    // 
    public void SoundCall(string name)
    {
        switch(name) // 입력한 string(문자열)에 따라 원하는 사운드 출력
        {
            case "Collision":
                audioSource.clip = audioClip[0];
                audioSource.Play();
                break;
            case "Move":
                audioSource.clip = audioClip[1];
                audioSource.Play();
                break;
            case "Coin":
                audioSource.clip = audioClip[2];
                audioSource.Play();
                break;
            
        }
    }
}
