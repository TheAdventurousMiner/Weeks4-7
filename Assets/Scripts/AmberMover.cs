using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmberMover : MonoBehaviour
{
    //Use public GameObject to drag the egg prefab into the script
    //which will be spawned using bool and if statements in Update()
    public GameObject dinoEgg;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Create a new Vector 3 and assign Camera.main.ScreenToWorldPoint so that the object follows the mouse within
        //the main Camera and follows the mouse coordinates within the world space.
        //Use "Input.mousePosition" inside the brackets to get access to the mouse and set the z coordinate to 0
        //since we're using 2D.
        Vector3 amberFollow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        amberFollow.z = 0f;
        //assign the new Vector 3 to the object's transform.position
        transform.position = amberFollow;

        //use bool statement to run the code if the amber, followed by mouse position,
        //is near the location of the machine in the scene. In this case the machine
        //is past -0.3 and behind 3 in the x coordinates of the scene.
        bool isAmberNearMachineX = amberFollow.x > -0.3 && amberFollow.x < 3;
        //use bool statement to run the code if the amber, followed by mouse position,
        //is near the location of the machine in the scene. In this case the machine
        //is above -1 and below 2 in the y coordinates of the scene.
        bool isAmberNearMachineY = amberFollow.y > -1 && amberFollow.y < 2;

        //Check if the bool statements are true and access the spacebar and check if it
        //has been pressed
        if (isAmberNearMachineX && isAmberNearMachineY && Input.GetKey(KeyCode.Space))
        {
            //create a new Vector3 for the spawn location
            Vector3 spawnEgg = new Vector3(7.2f, 1.85f, 0f);
            //if the bool statements are true and the space bar is pressed
            //spawn the egg prefab contained in the public GameObject in the inspector
            //and spawn it at the new spawn location written above
            Instantiate(dinoEgg, spawnEgg, Quaternion.identity);
            //destroy the amber prefab after 3 seconds
            Destroy(gameObject, 3);
        }

    }
}
