using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankMover : MonoBehaviour
{
    public Slider speedSlider;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        speedSlider.value = speed;
    }

    // Update is called once per frame
    void Update()
    {
        bool ifRightKeyIsPressed = Input.GetKey(KeyCode.D);

        Vector3 newRightPos = transform.position + Vector3.right * speed;

        bool ifLeftKeyIsPressed = Input.GetKey(KeyCode.A);

        Vector3 newLeftPos = transform.position + Vector3.left * speed;

        if (ifRightKeyIsPressed)
        {
            transform.position = newRightPos;
        }

        if (ifLeftKeyIsPressed)
        {
            transform.position = newLeftPos;
        }
    }
    public void speedValue(float updatedSpeed)
    {
        speed = updatedSpeed;
    }
}
