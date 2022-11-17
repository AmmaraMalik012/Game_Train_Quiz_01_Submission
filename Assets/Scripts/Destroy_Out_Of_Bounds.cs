using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Out_Of_Bounds : MonoBehaviour
{
    /*public int points = 0;*/
    private float rightBound = 80;
    private float leftBound = -80;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // destroy out of range
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        // destroying player when obstacle hits it
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            /*Debug.Log("GameOver!");*/
        }
    }
}
