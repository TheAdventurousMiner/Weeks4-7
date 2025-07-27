using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisplay2 : MonoBehaviour
{
    public GameObject infoObjectTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (newMousePosition.x > 3.4 && newMousePosition.x < 4.8)
        {
            infoObjectTwo.SetActive(true);
        }
        else
        {
            infoObjectTwo.SetActive(false);
        }
    }
}
