using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeukocyteSpawnA : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject leukocyte;
    public int direction;
    Vector2 yMin;
    public float y;

    void Start()
    {
        StartCoroutine(spawnTime());

        yMin.y = y;
        spawnTime();
    }


    



    IEnumerator spawnTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Instantiate(leukocyte, new Vector2(spawnPoint.position.x, yMin.y), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }
}
