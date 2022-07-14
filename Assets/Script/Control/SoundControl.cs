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
        switch(name) // �Է��� string(���ڿ�)�� ���� ���ϴ� ���� ���
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
