using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
 
    private int value;
    public GameObject[] tireStack; //Ư���� ���� ���� ����
  

    void Start()
    {
        // 0~2 �������� ��ȯ
        value = Random.Range(0, 3);

        for(int i=0;i< tireStack.Length;i++)
        {
            tireStack[i].SetActive(false);
        }

        tireStack[value].SetActive(true);
    }
   /* void Update()
    {
        if(GameManager.instance.state == false) return;

     //   transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);

        if (transform.position.z <= -10f)
        {
            //Destroy(gameObject);
            gameObject.transform.position = new Vector3(0, -0.4f, 7.5f);
            //ObjectPool.Instance.InsertQueue(gameObject);
        }
    }*/

    /*//private void OnBecameInvisible(): ī�޶� ���ߴ� ȭ�� ������ �̺�Ʈ�� �ߵ��ϴ� �Լ�
    // MeshRender �� �ʿ���
    private void OnBecameInvisible()
    {
        
    }*/



}
