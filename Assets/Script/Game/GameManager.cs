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

    void Start()
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
    }
    public void Load()
    {
        coin = PlayerPrefs.GetInt("Coin");
    }

 
}
