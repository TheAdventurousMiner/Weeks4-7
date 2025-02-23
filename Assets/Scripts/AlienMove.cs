using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMove : MonoBehaviour
{
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        }
        if (screenPos.x > Screen.width)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
        }

        transform.position = pos;
    }
    public void Alienspeed(float alienSpeed)
    {
        speed = alienSpeed;
    }
}
