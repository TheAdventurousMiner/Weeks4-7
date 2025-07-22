using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipMover : MonoBehaviour
{
    public float speed;
    private float direction = 1;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            transform.position += Vector3.right * speed * Time.deltaTime * direction;
        }
        
    }

    public void OnMoveClick()
    {
        moving = true;
        Debug.Log("Move was clicked.");
    }

    public void OnStopClick()
    {
        moving = false;
    }

    public void OnFlipClick()
    {
        direction *= -1;
    }
}
