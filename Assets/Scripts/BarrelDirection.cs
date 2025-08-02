using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelDirection : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float bulletSpeed = 1f;
    public AudioSource bulletAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector3 start = transform.position;
        Vector3 end = mousePos;

        Vector3 direction = end - start;

        transform.right = direction;

        bool leftClick = Input.GetMouseButtonDown(0);

        if (leftClick)
        {
            
            GameObject spawnedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            bulletAudio.Play();

            Bullet bulletscript = spawnedBullet.GetComponent<Bullet>();
            bulletscript.moveDuration = bulletSpeed;
        
        }
    }
}
