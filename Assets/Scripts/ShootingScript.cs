using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    [SerializeField] int damageDealt = 20;
    [SerializeField] LayerMask layerMask;

	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        layerMask |= Physics.IgnoreRaycastLayer;
        layerMask = ~layerMask;
	}
	
	void Update ()
    {
		if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if (Physics.Raycast (mouseRay, out hitInfo, 100, layerMask))
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red, 5.0f);
                print(hitInfo.transform.name);
                Health enemyHealth = hitInfo.transform.GetComponent<Health>();
                
                if (enemyHealth != null)
                {
                    enemyHealth.Damage(damageDealt);
                }
            }
        }
	}
}
