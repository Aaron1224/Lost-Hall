using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Camera mainCam;
    public GameObject player;

    private void Start()
    {
        mainCam = Camera.main;
        mainCam.transform.position = new Vector3(-6.87f, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        CameraMove();   
    }

    void CameraMove()
    {
        if(player.transform.position.x > -10 && player.transform.position.x < -2.3f)
        {
            mainCam.transform.position = new Vector3(-6.87f, transform.position.y, transform.position.z);
        }
        else if(player.transform.position.x >= -2.3f && player.transform.position.x < 6.14f)
        {
            mainCam.transform.position = new Vector3(1.34f, transform.position.y, transform.position.z);
        }
        else if (player.transform.position.x >= 6.14f)
        {
            mainCam.transform.position = new Vector3(9.64f, transform.position.y, transform.position.z);
        }
    }
}
