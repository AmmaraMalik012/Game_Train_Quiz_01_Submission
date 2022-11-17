using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Restart : MonoBehaviour
{
    // private float restartDelay = 0.01f;
    // public int lifeCount = 3;

    void OnCollisionEnter(Collision col)
    {
        // if collide with obstacle or water restart level
        if (col.gameObject.tag == "Obstacle")
        {
            Restart();
        }
        else if (col.gameObject.tag == "Water")
        {
            Restart();
        }
    }

    void Restart()
    {
        // load active scene (reloding existing scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
