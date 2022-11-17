using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Check : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if player is on the ground play particle effect
    void OnTriggerEnter(Collider col){
        Instantiate (particles, transform.position, Quaternion.identity);
    }
}
