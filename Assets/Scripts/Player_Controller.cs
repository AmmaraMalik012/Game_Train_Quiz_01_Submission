using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody playerRb;
    private float forceSpeed = 5;
    public float gravityModifier;
    public int speed = 15;
    private bool isOnGround = true;
    public GameObject camera;
    public GameObject player;
    public Vector3 offset = new Vector3(4, 4, -8);

    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        /* getting player input 
        if player is on ground then jump when key is pressed
        if player is pressing key but player is in air no force would be applied*/

        if (Input.GetKey(KeyCode.UpArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * forceSpeed, ForceMode.Impulse);
            playerRb.AddForce(Vector3.forward * speed * forceSpeed, ForceMode.Impulse );
            isOnGround = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * forceSpeed, ForceMode.Impulse);
            playerRb.AddForce(Vector3.right * speed * forceSpeed, ForceMode.Impulse);
            transform.Rotate(0, 90, 0);
            isOnGround = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * forceSpeed, ForceMode.Impulse);
            playerRb.AddForce(-Vector3.right * speed * forceSpeed, ForceMode.Impulse);
            isOnGround = false;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * forceSpeed, ForceMode.Impulse);
            playerRb.AddForce(-Vector3.forward * speed * forceSpeed, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // play particles if player is on ground
        isOnGround = true;
        
        Instantiate (particles, transform.position, Quaternion.identity);
    }

    void LateUpdate()
    {
        // making camera follow the player
        camera.transform.position = player.transform.position + offset;
    }


}
