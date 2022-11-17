using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    // public GameObject obstacleSpawn;
    private int obstacleCount = 0;
    public float time;
    public GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnObstacle()
    {
        while (obstacleCount < 100)
        {
            
            //x range of obstacle spwan randomly
            /*xposition = Random.Range(-8, 8);*/
            Instantiate(obstaclePrefab, gameObject.transform.position, Quaternion.identity);
            // Instantiate(obstaclePrefab);
            //wait for the new obstacle spawn
            yield return new WaitForSeconds(time);
            obstacleCount += 1;
        }
    }
}
