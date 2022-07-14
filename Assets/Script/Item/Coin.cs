using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(Vector3.forward*100 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Character")
        {
            GameManager.instance.coin += 10;
            gameObject.SetActive(false);

            GameManager.instance.Save();
            SoundControl.Instance.SoundCall("Coin");
        }
    }

    //���� ������Ʈ�� ��Ȱ��ȭ �Ǿ����� ȣ��Ǵ� �Լ�
    private void OnDisable()
    {
        Invoke("Delay", 1f);
    }
   
    public void Delay()
    {
        gameObject.SetActive(true);
    }
}
