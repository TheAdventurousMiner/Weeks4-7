using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipMover : MonoBehaviour
{
    public AudioSource moveClickAudioSource;
    public AudioSource stopClickAudioSource;
    public AudioSource flipClickAudioSource;
    public AudioClip stopClickAudioClip;
    public List<AudioClip> flipClickAudioClip;
    public Slider staminaSlider;
    public float maxStamina, minStamina;
    public float exhaustRate;
    public float exhaustedSpeed;
    private float currentStamina;
    public float speed;
    private float direction = 1;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        stopClickAudioSource.clip = stopClickAudioClip;
        currentStamina = maxStamina;
        staminaSlider.value = currentStamina / maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            transform.position += Vector3.right * speed * Time.deltaTime * direction;

            currentStamina -= exhaustRate * Time.deltaTime;
            staminaSlider.value = currentStamina / maxStamina;
            if (currentStamina <= 0)
            {
                speed = exhaustedSpeed;
            }
        }
        
        
    }

    public void OnMoveClick()
    {
        moving = true;
        moveClickAudioSource.Play();
        Debug.Log("Move was clicked.");
    }

    public void OnStopClick()
    {
        stopClickAudioSource.Play();
        moving = false;
    }

    public void OnFlipClick()
    {
        direction *= -1;
        //take our clips and choose one randomly
        //Get a random number from 0 to (the size of the list minus one)
        int randomIndex = UnityEngine.Random.Range(0, flipClickAudioClip.Count);
        AudioClip randomlyChosenClip = flipClickAudioClip[randomIndex];
        flipClickAudioSource.PlayOneShot(randomlyChosenClip);
    }
}
