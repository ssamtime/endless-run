using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinActive : MonoBehaviour
{
    public GameObject[] coin;

    void Start()
    {
        coin[Random.Range(0,3)].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
