using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static : ���α׷��� ����� ������ �޸𸮿��� �������, ������ ������ �����
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
