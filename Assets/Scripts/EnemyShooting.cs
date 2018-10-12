using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    float nextTimeAttackIsAllowed = -1.0f;
    [SerializeField] float attackDelay = 1.0f;
    [SerializeField] int damageDealt = 5;

    private Transform target;
    [SerializeField] private float rotationSpeed = 0.5f;

    void Start ()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
	}
	
	void Update ()
    {
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Mathf.Min(rotationSpeed * Time.deltaTime, 1));
	}
}
