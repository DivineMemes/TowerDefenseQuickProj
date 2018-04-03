using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour, IDamageable
{


    public float currentHealth;
    float Health = 30;


 public void ApplyDamage(float damage)
{
    currentHealth -= damage;
}


void Start ()
    {
        currentHealth = Health;
	}
	
	void Update ()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("dead");
        }
	}



}
