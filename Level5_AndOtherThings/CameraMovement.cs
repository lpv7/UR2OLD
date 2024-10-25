using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject mainCamera;
    public Collider2D[] cameraTriggers;
    public GameObject character;
    public GameObject endWall;

    int cameraPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        endWall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCamera(Collider2D trigger)
    {
        // NOTE: PLEASE READ!
        // Triggers should be placed in the order at which they appear in the level, otherwise they may not work right!
        // Every screen is 18 tiles long and 10 tiles tall, keep that in mind!

        Debug.Log("WE GOT ONE");
        Debug.Log("IT'S A BIG ONE!");
        if (trigger.gameObject.name == "Trigger1")
        {
            if (cameraPos != 0)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 0;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger2")
        {
            if (cameraPos != 1)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 1;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger3")
        {
            if (cameraPos != 1)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 1;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger4")
        {
            if (cameraPos != 2)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 2;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger5")
        {
            if (cameraPos != 2)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 2;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger6")
        {
            if (cameraPos != 3)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 3;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger7")
        {
            if (cameraPos != 3)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 3;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger8")
        {
            if (cameraPos != 4)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 4;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger9")
        {
            if (cameraPos != 4)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 4;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger10")
        {
            if (cameraPos != 5)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 5;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger11")
        {
            if (cameraPos != 5)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 5;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger12")
        {
            if (cameraPos != 6)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 6;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger13")
        {
            if (cameraPos != 6)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 6;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger14")
        {
            if (cameraPos != 7)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 7;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger15")
        {
            if (cameraPos != 7)
            {
                mainCamera.transform.position -= new Vector3(18, 0, 0);
                cameraPos = 7;
                Debug.Log("oh yeah");
            }
        }
        else if (trigger.gameObject.name == "Trigger16")
        {
            if (cameraPos != 8)
            {
                mainCamera.transform.position += new Vector3(18, 0, 0);
                cameraPos = 8;
                Debug.Log("oh yeah");
                endWall.SetActive(true);
            }
        }
    }
}
