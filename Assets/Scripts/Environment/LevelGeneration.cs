//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LevelGeneration : MonoBehaviour
//{
//    public GameObject[] Section;
//    public int zpos = 150;
//    public bool creatingSection = false;
//    public int secNum;

//    // Update is called once per frame
//    void Update()
//    { 
//        if (creatingSection == false)
//        {
//            creatingSection = true;
//            // generateSection is not a coroutine; 
//            // coroutine used for timedelay; here btw sections
//            StartCoroutine(GenerateSection());

//        }
//    IEnumerator GenerateSection()
//        {
//            secNum = Random.Range(0, 3); // values are 0,1,2 only .
//           // Instantiate(Section[secNum],new Vector3(0,0,zpos), Quaternion.identity);  old script (1)

//            Quaternion rotation = Quaternion.Euler(0, 90, 0);            // rotates 90 to solve previos problem
//            Instantiate(Section[secNum], new Vector3(0, 0, zpos), rotation);

//            zpos += 50;
//            yield return new WaitForSeconds(3);
//            creatingSection = false;
//        }
//    }
//}


// with detetion of previous platform
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject[] Section;
    public int zpos = 150;
    public bool creatingSection = false;
    public int secNum;
    public int maxSections = 10; // Set the maximum number of sections to keep active
    private List<GameObject> activeSections = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3); // values are 0,1,2 only.

        // Define a 90-degree rotation around the Y-axis
        Quaternion rotation = Quaternion.Euler(0, 90, 0);

        // Instantiate and add the new section to the list
        GameObject newSection = Instantiate(Section[secNum], new Vector3(0, 0, zpos), rotation);
        activeSections.Add(newSection);
        zpos += 50;

        // If the list exceeds the maximum allowed sections, destroy the oldest one
        if (activeSections.Count > maxSections)
        {
            Destroy(activeSections[0]);
            activeSections.RemoveAt(0);
        }

        yield return new WaitForSeconds(5);
        creatingSection = false;
    }
}
