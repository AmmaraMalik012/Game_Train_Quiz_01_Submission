using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_particles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // destroy particles after playing them for 1sec
        Destroy (gameObject, 1f);
    }
}
