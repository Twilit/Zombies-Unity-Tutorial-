using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{



	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                print("mine damaged: " + other.tag);

                health.Damage(30);
                //destroys mine
                Destroy(gameObject);
            }
        }
    }
}
