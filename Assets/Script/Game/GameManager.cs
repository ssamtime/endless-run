using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : ���α׷��� ����� ������ �޸𸮿��� �������, ������ ������ �����
    public static GameManager instance;
    public float speed;
    public bool state; //true false ���� �����Ҽ�����


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
        //while : ������ ���̸� ��� ����
        while(state)
        {
            //1�ʵ��� ����� �ӵ���
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
