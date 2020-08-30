﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSoundPlayer : MonoBehaviour
{

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
        else
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
