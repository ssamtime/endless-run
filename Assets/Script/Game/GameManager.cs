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
    }

}
