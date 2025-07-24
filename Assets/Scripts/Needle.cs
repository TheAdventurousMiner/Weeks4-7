using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Create a new Vector 3 and assign Camera.main.ScreenToWorldPoint so that the object follows the
        //direction of the mouse within the main Camera and follows the mouse coordinates within the world space.
        //Use "Input.mousePosition" inside the brackets to get access to the mouse and set the z coordinate to 0
        //since we're using 2D.
        Vector3 needleDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        needleDirection.z = 0f;

        //set a new Vector3 for the starting position of the object which is the default transform.position
        Vector3 startDirection = transform.position;
        //set a new Vector3 for the end position of the object which is mouse position assigned to the first Vector3 that I named
        Vector3 endDirection = needleDirection;

        //calculate the direction of the object and mouse position to look at the mouse while staying at
        //its set coordinates. 
        Vector3 newDirection = endDirection - startDirection;

        //use transform.up to get access to the y coordinate of the object and assign the new calculated direction
        transform.up = newDirection;

    }
}
