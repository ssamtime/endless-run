using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : 프로그램이 종료될 때까지 메모리에서 살아있음, 데이터 영역에 저장됨
    public static GameManager instance;

    public float speed;
    public bool state; //true false 값만 저장할수있음
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
