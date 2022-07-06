using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstalceCreate : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        //InvokeRepeating : �����Ŀ� �Լ��� ����ǰ� ���ʵ��� �Լ��� �ݺ������� ����Ǵ� �Լ�.
        InvokeRepeating("Create",5,5);
    }
   
    public void Create()
    {
        if (GameManager.instance.state == false) return;

        Instantiate(obstacle, new Vector3(0, 0.2f, 7.5f), Quaternion.identity);
    }
}
