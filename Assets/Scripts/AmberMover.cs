using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmberMover : MonoBehaviour
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
        //Use "Input.mousePosition" inside the brackets to get access to the mouse and set the z coordinate to 0
        //since we're using 2D.
        Vector3 amberFollow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        amberFollow.z = 0f;
        //assign the new Vector 3 to transform.position
        transform.position = amberFollow;
    }
}
