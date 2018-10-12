using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Transform playerModel;
    CharacterController controller;

    [SerializeField] float moveSpeed = 0.5f;

	void Start ()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
	}
	
	void Update ()
    {
        Vector3 direction = playerModel.position - transform.position;
        
        //originally 2, reduced so hitbox collides with player
        if (direction.magnitude > 1.5)
        {
            controller.Move(moveSpeed * direction * Time.deltaTime);
        }

        //face player
        transform.rotation = Quaternion.LookRotation(direction);
	}
}
