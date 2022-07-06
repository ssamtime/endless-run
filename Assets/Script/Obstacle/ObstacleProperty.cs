using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
 
    private int value;
    public GameObject[] tireStack; //Ư���� ���� ���� ����
    public Animator[] animator;

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
    void Update()
    {
        if(GameManager.instance.state == false) return;

        transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);

        if (transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Character")
        {
            animator[value].enabled = true;
        }
    }
    /*//private void OnBecameInvisible(): ī�޶� ���ߴ� ȭ�� ������ �̺�Ʈ�� �ߵ��ϴ� �Լ�
    // MeshRender �� �ʿ���
    private void OnBecameInvisible()
    {
        
    }*/



}
