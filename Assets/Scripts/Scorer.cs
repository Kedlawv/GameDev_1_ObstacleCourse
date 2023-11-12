using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score;

    private void OnCollisionEnter(Collision collision)
    {
        
        // Maybe it would be better to reset players rigid body here ?
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You have bumped in to things: " +  score);
        }
    }

}
