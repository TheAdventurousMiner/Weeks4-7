using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmberMover : MonoBehaviour
{
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
        //assign the new Vector 3 to transform.position
        transform.position = amberFollow;

        bool isAmberNearMachineX = amberFollow.x > -0.3 && amberFollow.x < 3;
        //use bool statement to run the code if the amber, followed by mouse position, is near the location of the machine in the scene. In this case the machine
        //is above -1 and below 2 in the y coordinates of the scene.
        bool isAmberNearMachineY = amberFollow.y > -1 && amberFollow.y < 2;

        //if bool statement is true, change the colour of the detector to green, if not, change it to red.
        if (isAmberNearMachineX && isAmberNearMachineY && Input.GetKey(KeyCode.Space))
        {
            Vector3 spawnEgg = new Vector3(7.2f, 1.85f, 0f);
            Instantiate(dinoEgg, spawnEgg, Quaternion.identity);
            Destroy(gameObject, 3);
        }

    }
}
