﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator walkanimator;
    public GameObject player;
    public Sprite walk_0;
    public Sprite walk_5;
    public Sprite walk_13;
    public float walkSpeed = 0.046f;

    void Start()
    {
        player.GetComponent<SpriteRenderer>().sprite = walk_0;
        walkanimator = player.GetComponent<Animator>();
        walkanimator.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        StepSound();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {

        }
        if (Input.GetKey(KeyCode.S))
        {

        }

        if (Input.GetKey(KeyCode.A))
        {
            walkanimator.enabled = true;
            player.GetComponent<SpriteRenderer>().flipX = true;
            transform.position = new Vector3(transform.position.x - walkSpeed, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            walkanimator.enabled = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = new Vector3(transform.position.x + walkSpeed, transform.position.y, transform.position.z);
        }
        else
        {
            walkanimator.enabled = false;
            player.GetComponent<SpriteRenderer>().sprite = walk_0;
        }
    }

    void StepSound()
    {
        if (player.GetComponent<SpriteRenderer>().sprite == walk_5 || player.GetComponent<SpriteRenderer>().sprite == walk_13)
        {
            FindObjectOfType<AudioController>().concreteStep.Play();
        }
    }
}
