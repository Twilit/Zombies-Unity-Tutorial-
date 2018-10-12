using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{

    private void OnEnable()
    {
        this.transform.position =
            new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
    }

    private void OnDisable()
    {
        this.transform.position =
            new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
