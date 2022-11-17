using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Reverse_Movement : MonoBehaviour
{
    public float Speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving obstacle in reverse direction
        transform.Translate(-Vector3.right * Time.deltaTime * Speed);
    }
}
