using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{ // static - so that other scripts can interact with the variable
  // create without static variable for debug,etc
  // static variable are not shown in inspector, also their values given to internal varioables are not reflected until play button is clicked
  // created 2 extra variable for setting/changing boundary for diff levels
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public float internalLeft;
    public float internalRight;
    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
