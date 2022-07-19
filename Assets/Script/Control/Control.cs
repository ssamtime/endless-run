using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Animator animator;
    public GameObject[] item;

    private void Start()
    {
        if(GameManager.instance.hat>0)
        {
            item[0].SetActive(true);
        }
        if (GameManager.instance.rod > 0)
        {
            item[1].SetActive(true);
        }
    }
    void Update()
    {
        if (GameManager.instance.state == false) return;

        if (Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x <= -1.4) return;
            
            transform.position += new Vector3(-1.5f, 0, 0);
            SoundControl.Instance.SoundCall("Move");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x >= 1.4) return;

            transform.position += new Vector3(1.5f, 0, 0);
            SoundControl.Instance.SoundCall("Move");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            animator.SetTrigger("Death");
            GameManager.instance.speed = 0;
            GameManager.instance.state = false;
            InterfaceManager.instance.ActiveUI();
            SoundControl.Instance.SoundCall("Collision");
        }
        
       
    }
    // collision : �浹��ü�� ��������
    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            animator.SetTrigger("Death");
            GameManager.instance.speed = 0;

            GameManager.instance.state = false;

        }
    }*/
}
