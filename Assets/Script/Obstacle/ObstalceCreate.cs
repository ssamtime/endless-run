using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstalceCreate : MonoBehaviour
{
    //public GameObject obstacle;

    void Start()
    {
        //InvokeRepeating : 몇초후에 함수가 실행되고 몇초동안 함수가 반복적으로 실행되는 함수.
        InvokeRepeating("Create",2,5);
    }
   
    public void Create()
    {
        if (GameManager.instance.state == false) return;

        ObjectPool.Instance.GetQueue();
    }
}
