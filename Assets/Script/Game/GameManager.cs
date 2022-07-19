using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : ���α׷��� ����� ������ �޸𸮿��� �������, ������ ������ �����
    public static GameManager instance;

    public float speed;
    public bool state; //true false ���� �����Ҽ�����
    public int coin;
    public int hat;
    public int rod;

    void Awake()
    {
        Load();
        if (instance == null)
        {
            instance = this;
        }

        state = true;

      //  StartCoroutine(SpeedIncrease());
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Coin",coin);
        PlayerPrefs.SetInt("Hat", hat);
        PlayerPrefs.SetInt("Rod", rod);
    }
    public void Load()
    {
        coin = PlayerPrefs.GetInt("Coin");
        hat = PlayerPrefs.GetInt("Hat");
        rod = PlayerPrefs.GetInt("Rod");

    }

 
}
