using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;
    
    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        this.transform.Rotate(0, rotationAmount, 0);
    }
}
