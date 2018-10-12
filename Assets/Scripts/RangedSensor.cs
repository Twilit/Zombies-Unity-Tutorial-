using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedSensor : MonoBehaviour {

    private bool senseTarget;

    public bool SenseTarget
    {
        get
        {
            return senseTarget;
        }
    }

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            senseTarget = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            senseTarget = false;
        }
    }
}
