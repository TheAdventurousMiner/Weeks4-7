using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisplay1 : MonoBehaviour
{
    public GameObject infoObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (newMousePosition.x > -5 && newMousePosition.x < -3.3)
        {
            infoObject.SetActive(true);
        }
        else
        {
            infoObject.SetActive(false);
        }
    }
}
