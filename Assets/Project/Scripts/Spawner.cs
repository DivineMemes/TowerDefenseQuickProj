using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    

	
	void Start ()
    {
        for (int i = 0; i < 30; ++i)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        //int i = 0;
    }
	
	
	void Update ()
    {
		//for(int i = 0; i < 10; ++i)
        //{
        //    Instantiate(enemy, transform.position, Quaternion.identity);
        //}
	}





}
