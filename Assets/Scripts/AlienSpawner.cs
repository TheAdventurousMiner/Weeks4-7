using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject alienSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnAlien()
    {
        float alienX = Random.Range(-3, 3);
        float alienY = Random.Range(-3, 3);

        Vector2 alienPos = new Vector2(alienX, alienY);
        GameObject newAlien = Instantiate(alienSpawn, alienPos, Quaternion.identity);

        Destroy(newAlien, 4);
    }
}
