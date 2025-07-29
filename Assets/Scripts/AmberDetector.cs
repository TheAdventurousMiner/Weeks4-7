using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmberDetector : MonoBehaviour
{
    //Create a variable for  the sprite renderer class to get change the sprite renderer
    SpriteRenderer detectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Get access to the SpriteRender component of the object the script is attatched to
        detectRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a new Vector3 to access the mouse position (Input.mousePosition) in the world space (ScreenToWorldPoint) within the main camera (Camera.main)
        Vector3 amberLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //use bool statement to run the code if the amber, followed by mouse position, is near the location of the machine in the scene. In this case the machine
        //is past -0.3 and behind 3 in the x coordinates of the scene.
        bool isAmberNearMachineX = amberLocation.x > -0.3 && amberLocation.x < 3;
        //use bool statement to run the code if the amber, followed by mouse position, is near the location of the machine in the scene. In this case the machine
        //is above -1 and below 2 in the y coordinates of the scene.
        bool isAmberNearMachineY = amberLocation.y > -1 && amberLocation.y < 2;

        //if bool statement is true, change the colour of the detector to green, if not, change it to red.
        if (isAmberNearMachineX && isAmberNearMachineY)
        {
            //changes colour of the sprite to green.
            detectRenderer.color = Color.green;
        }
        else
        {
            //changes the colour of the sprite to red.
            detectRenderer.color = Color.red;
        }
    }
}
