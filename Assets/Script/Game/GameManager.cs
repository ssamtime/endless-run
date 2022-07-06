using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : 프로그램이 종료될 때까지 메모리에서 살아있음, 데이터 영역에 저장됨
    public static GameManager instance;
    public float speed;
    public bool state; //true false 값만 저장할수있음


    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        state = true;
    }

}
