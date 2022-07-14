using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Animator animator;
    public ParticleSystem effect;
    
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
        
        if(other.gameObject.tag=="Coin")
        {
            effect.Play();
        }
    }
    // collision : 충돌물체에 대한정보
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
