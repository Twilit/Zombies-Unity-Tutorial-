using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField] float sensitivity = 5.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
	}
}
