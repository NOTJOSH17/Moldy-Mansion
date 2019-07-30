﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public PlayerHealth barLife;
    public GameObject player;
    public float healthAmount;
    public AudioSource SoundSource;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        if (hitInfo.gameObject.tag == "Player")
        {
            SoundSource.Play();
            barLife.AddHealth(healthAmount);
            Destroy(gameObject);
        }
        
    }
}
