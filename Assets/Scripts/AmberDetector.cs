using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmberDetector : MonoBehaviour
{
    //Make a public sprite renderer to get access to the sprite in the inspector
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //create a new Vector3 to access the mouse position (Input.mousePosition) in the world space (ScreenToWorldPoint) within the main camera (Camera.main)
        Vector3 amberLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //use bool statement to run the code if the amber, followed by mouse position, is near the location of the machine in the scene. In this case the machine
        //is past 1 in the x coordinates in the scene and above -2 in the y coordinates of the scene.
        bool isAmberNearMachine = amberLocation.x > 1 && amberLocation.y > -2;

        //if bool statement is true, change the colour of the detector to green, if not, change it to red.
        if (isAmberNearMachine)
        {
            //changes colour of the sprite to green.
            spriteRenderer.color = Color.green;
        }
        else
        {
            //changes the colour of the sprite to red.
            spriteRenderer.color = Color.red;
        }
    }
}
