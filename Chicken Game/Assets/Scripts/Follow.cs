using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour 
{
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;

	public Transform Chicken;
	public int damage;
	public Transform target;
	public Transform playerHealth;
	
	public Transform pcHealth;

	void OnTriggerStay(Collider other)
{
		if (other.gameObject.name =="Player")
		{	
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(Player);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		else if(other.gameObject.name =="Chicken")
			{	
			Debug.Log("Chicken has entered wolf's trigger");
			transform.LookAt(Player);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}	
	}
	void OnCollisionEnter(Collision other){

		if(other.gameObject.name =="Player"){
		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();
		print("Woof Woof Woof");

		if(pcHealth !=null){
		pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);	
	
		}
	}
}

}	


