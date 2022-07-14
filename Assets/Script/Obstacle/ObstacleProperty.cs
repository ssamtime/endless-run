using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
 
    private int value;
    public GameObject[] tireStack; //특정한 갯수 설정 가능
  

    void Start()
    {
        // 0~2 난수값을 반환
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

    /*//private void OnBecameInvisible(): 카메라가 비추는 화면 밖으로 이벤트를 발동하는 함수
    // MeshRender 가 필요함
    private void OnBecameInvisible()
    {
        
    }*/



}
