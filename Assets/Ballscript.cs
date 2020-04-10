﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello Game!");
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, -1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.name=="WallVertical" || other.collider.name == "WallVertical1")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
        }  
    }
}