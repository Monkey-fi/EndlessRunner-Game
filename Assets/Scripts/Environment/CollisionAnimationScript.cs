using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAnimationScript : MonoBehaviour
{ 
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ModelToAniamte;
    public GameObject turnOffParticularScript;
    public AudioSource crashThud; // yaha pe gameobject attach karna hai jismai audiosource component hai

      
    void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
        ModelToAniamte.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        turnOffParticularScript.GetComponent<GameOverSequence>().enabled = true;  // on collision turn on gameoversequeence to display gameovermenu screen
    }
}
