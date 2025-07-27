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
        Vector3 clawPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clawPosition.z = 0f;
        transform.position = clawPosition;
    }
}
