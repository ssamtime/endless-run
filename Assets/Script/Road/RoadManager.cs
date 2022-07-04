using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject road;
    public float speed;

    List<GameObject> roadList;

    int firstRoad =0;
    int lastRoad =0;

    Vector3 nextRoad =Vector3.left;


    void Start()
    {
        roadList = new List<GameObject>();

        for(int i=0;i<5;i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 20;
        }
    }

    void Update()
    {
        for(int i=0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if(roadList[lastRoad].transform.position.z <= -20)
        {
            // 0= 0-1
            firstRoad = lastRoad - 1;
            if(firstRoad < 0)
            {
                // -1 = 5-1
                firstRoad = roadList.Count - 1;
            }

            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 20;

            lastRoad++;

            if(lastRoad>=roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
