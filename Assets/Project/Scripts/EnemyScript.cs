using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    NavMeshAgent enemy;
    public GameObject target;
    public float damageValue;
    //IDamageable damageable;
	void Start ()
    {
        enemy = gameObject.GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Target");
    }
	
		void Update ()
    {
        enemy.destination = target.transform.position;
	}


    


    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Target")
        {
            IDamageable damageable = other.collider.GetComponent<IDamageable>();
            damageable.ApplyDamage(damageValue);
            Destroy(gameObject);
        }
    }
}
