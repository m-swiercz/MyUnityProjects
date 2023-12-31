﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float forwardInput;
    public float horizontalInput;


    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate player with hotizontal Input
        transform.Rotate(Vector3.up, speed * Time.deltaTime * horizontalInput);
    }
}
