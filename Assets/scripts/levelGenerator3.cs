using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator3 : MonoBehaviour
{
    public float maxX = 17, minX=8, maxY=8, minY=1, maxZ=25, minZ=-7;
    public GameObject blue, red;
    void Start()
    {
        for(int i = 0; i < 40; i++)
        {
            GameObject temp = Instantiate(blue);
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(minZ, maxZ);

            temp.transform.position = new Vector3(randomX, randomY, randomZ);
        }
        for (int i = 0; i < 500; i++)
        {
            GameObject temp = Instantiate(red);
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(minZ, maxZ);

            temp.transform.position = new Vector3(randomX, randomY, randomZ);
        }
    }

}
