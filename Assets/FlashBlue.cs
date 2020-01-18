using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBlue : MonoBehaviour
{
    public SpriteRenderer spriteToSwitch;
    void Start()
    {
        
    }


    float timeToSwitch = 1f;
    float nextTimeToSwitch =1f;
    void Update()
    {
        if (Time.time > nextTimeToSwitch)
        {
            nextTimeToSwitch = Time.time + timeToSwitch;
            if (spriteToSwitch.color.g > 0.1f)
            {
                spriteToSwitch.color = new Color(0f, 0f, 1f);
            }
            else 
            {
                spriteToSwitch.color = new Color(1f, 1f, 1f);
            }
        }
    }
}

