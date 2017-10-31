using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : MonoBehaviour 

{
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;

	public Transform chickenPen;

	public Transform Wolf;
	public int points = 10;

	void OnTriggerStay(Collider other)
{
		if (other.gameObject.name =="Player")
		{	
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(Player);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
		else if(other.gameObject.name =="Wolf")
			{	
			Debug.Log("Wolf has entered Chicken's trigger");
			transform.LookAt(Wolf);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}	
}	

	 void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name =="Player"){

			//Destroy(gameObject);
			//Add points to score 
			scoreManager.AddPoints(points);
			//Send chicken to chicken pen
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;

		}

	}



}
	