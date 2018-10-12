using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int maximumHealth = 100;
    [SerializeField] int currentHealth = 0;

	void Start ()
    {
        currentHealth = maximumHealth;
	}
	
    public bool IsDead { get { return currentHealth <= 0; } }

    public int getHealth()
    {
        return currentHealth;
    }

    public int getMaxHealth()
    {
        return maximumHealth;
    }

    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;

        if (currentHealth <= 0)
        {
            if (gameObject.tag != "Player")
            {
                UIScript.updateScore(30);

                Destroy(gameObject);
            }
            else
            {
                currentHealth = 0;
                gameObject.GetComponent<LookX>().enabled = false;
                gameObject.GetComponent<ShootingScript>().enabled = false;
                gameObject.GetComponent<InteractionScript>().enabled = false;
                gameObject.transform.GetChild(0).GetComponent<LookY>().enabled = false;
            }
        }
        else if (currentHealth > maximumHealth)
        {
            currentHealth = maximumHealth; //not over max
        }
    }

	void Update ()
    {
		
	}
}
