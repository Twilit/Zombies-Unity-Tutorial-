﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{



	void Start ()
    {
		
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.F))
        {
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            if (Physics.Raycast(mouseRay, out hitInfo))
            {
                DoorOpenScript door = hitInfo.transform.GetComponent<DoorOpenScript>();
                if (door)
                {
                    door.enabled = true;
                }
            }
        }
	}
}
