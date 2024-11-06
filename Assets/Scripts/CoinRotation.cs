using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotationSpeed = 1;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}