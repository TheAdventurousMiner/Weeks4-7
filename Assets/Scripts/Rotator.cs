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
        //Vector3 newRotation = transform.eulerAngles;
       // newRotation.z += 1f;
        //transform.eulerAngles = newRotation;

    }
    public void rotationValue()
    {
        
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += 1f;
        transform.eulerAngles = newRotation;

    }
}
