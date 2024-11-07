using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);  // script in action after 3 seconds (bsz script not set to trigger on collision)
        liveCoins.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
    }
}
