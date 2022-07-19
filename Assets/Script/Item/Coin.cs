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

    //게임 오브젝트가 비활성화 되었을때 호출되는 함수..
    private void OnDisable()
    {
        Invoke("Delay", 1f);
    }
   
    public void Delay()
    {
        gameObject.SetActive(true);
    }
}
