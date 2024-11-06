using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAnimationScript : MonoBehaviour
{ 
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ModelToAniamte;

    void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
        ModelToAniamte.GetComponent<Animator>().Play("Stumble Backwards");   
    }
}
