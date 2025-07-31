using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawMover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create a new Vector 3 and assign Camera.main.ScreenToWorldPoint so that the object follows the mouse within
        //the main Camera and follows the mouse coordinates within the world space.
        //Use "Input.mousePosition" inside the brackets to get access to the mouse
        Vector3 clawPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //set the z coordinate to 0 since we're using 2D
        clawPosition.z = 0f;
        //assign the new variable to the object's transform position
        transform.position = clawPosition;
    }
}
