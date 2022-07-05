using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : 프로그램이 종료될 때까지 메모리에서 살아있음, 데이터 영역에 저장됨
    public static GameManager instance;
    public float speed;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
