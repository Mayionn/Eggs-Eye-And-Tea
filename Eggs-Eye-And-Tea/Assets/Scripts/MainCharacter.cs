﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

    //Movement
    private int movementSpeed = 5;
    public SpriteRenderer sprite;

    public bool trigger;

    private void Update()
    {
        //Move right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
            sprite.flipX = false;
        }

        //Move left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            sprite.flipX = true;                                                            //flip the sprite if it moves the left AKA press A key
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trigger")
        {
            trigger = true;
        }
    }
}






