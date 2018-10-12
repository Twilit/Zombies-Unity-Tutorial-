using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject camera1;
    public GameObject camera2;

	void Start ()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
	}

	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, (transform.position + (new Vector3(10, 0, 0))), Color.red);
        if (Physics.Raycast(transform.position, transform.right, 10))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        else
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
    }
}
