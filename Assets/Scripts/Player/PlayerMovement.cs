using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 2;
    // Update is called once per frame
    void Update()
    {
    // translate -to change;vector3 - for movement; forward- this can be used for backward but with -ve moveSpeed;
    // moveSpeed - multiplier; Space.World - for relative speed world is chosen as reference;
    // translate - object will move with that speed (given inisde)
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { 
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            { 
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }

        }
    }
}
