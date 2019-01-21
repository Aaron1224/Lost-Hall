using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator walkanimator;
    public GameObject player;
    public Sprite walk_0;
    float stepTimer;
    public float timerSpeed;

    void Start()
    {
        player.GetComponent<SpriteRenderer>().sprite = walk_0;
        walkanimator = player.GetComponent<Animator>();
        walkanimator.enabled = false;
        stepTimer = timerSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
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
            transform.position = new Vector3(transform.position.x - 0.046f, transform.position.y, transform.position.z);

            stepTimer -= Time.deltaTime;
            if (stepTimer < 0)
            {
                FindObjectOfType<AudioController>().concreteStep.Play();
                stepTimer = timerSpeed;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            walkanimator.enabled = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = new Vector3(transform.position.x + 0.046f, transform.position.y, transform.position.z);

            stepTimer -= Time.deltaTime;
            if(stepTimer < 0)
            {

                FindObjectOfType<AudioController>().concreteStep.Play();
                stepTimer = timerSpeed;
            }
        }
        else
        {
            walkanimator.enabled = false;
            player.GetComponent<SpriteRenderer>().sprite = walk_0;
        }
    }
}
