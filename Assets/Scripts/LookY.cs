using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{

    [SerializeField] float sensitivityY;
    public float minimumY = -60f;
    public float maximumY = 90f;

    float rotationY = 0f;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
	}
}
