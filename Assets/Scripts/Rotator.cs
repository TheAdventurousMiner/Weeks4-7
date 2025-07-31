using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    //Create a new public void for the slider to get access to it
    public void rotationValue()
    {
        //create a new Vector3 variable that handles the object's rotation 
        //using eulerAngles
        Vector3 newRotation = transform.eulerAngles;
        //rotate the object along the z coordinate since we're using 2D
        //and increase the rotaion by 1
        newRotation.z += 1f;
        //assign the new rotation to the object's rotation
        transform.eulerAngles = newRotation;

    }
}
