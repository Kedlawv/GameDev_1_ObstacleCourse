using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score;

    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("You have bumped in to things: " +  score);
    }

}
