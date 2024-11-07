using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject coinEndDisplay;

    // Update is called once per frame
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text= "Coins:" + coinCount;
        coinEndDisplay.GetComponent<TMPro.TMP_Text>().text= "Coins:" + coinCount;
    }
}
