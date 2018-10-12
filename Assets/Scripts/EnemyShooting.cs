using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    float nextTimeAttackIsAllowed = -1.0f;
    [SerializeField] float attackDelay = 1.0f;
    [SerializeField] int damageDealt = 15;

    private Transform target;
    [SerializeField] private float rotationSpeed = 0.5f;
    RangedSensor sensor;

    void Start ()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;

        sensor = transform.GetChild(0).GetComponent<RangedSensor>();
	}
	
	void Update ()
    {
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        
        if (sensor.SenseTarget)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Mathf.Min(rotationSpeed * Time.deltaTime, 1));
            
            if (Time.time  >= nextTimeAttackIsAllowed)
            {
                Shoot();

                nextTimeAttackIsAllowed = Time.time + attackDelay;
            }
        }
	}

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Player")
            {
                Debug.DrawLine(transform.position, hit.point, Color.yellow, 1.0f);
                Health playerHealth = hit.transform.GetComponent<Health>();
                playerHealth.Damage(damageDealt);
                print("shot player");
            }
        }
    }
}
