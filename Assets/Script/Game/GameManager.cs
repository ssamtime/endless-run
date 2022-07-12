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

        StartCoroutine(SpeedIncrease());
    }

    IEnumerator SpeedIncrease()
    {
        //while : 조건이 참이면 계속 실행
        while(state)
        {
            //1초동안 대기후 속도업
            yield return new WaitForSeconds(1f);
            speed += 1;
            
            if(speed >= 50)
            {
                speed = 50;
            }

            if (state == false)
            {
                speed = 0;
            }
        }
        
    }
}
