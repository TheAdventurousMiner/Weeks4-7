using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmberSpawner : MonoBehaviour
{
    //create a public GameObject to add the amber prefab in the inspector
    public GameObject amberSpawn;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //create a new public void for the button to get access
    public void spawnAmber()
    {
        //spawn the prefab assigned in the public GameObject in the inspector
        Instantiate(amberSpawn);
    }
}
