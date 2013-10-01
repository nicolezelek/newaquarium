using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	public Vector3 destination = new Vector3(5f, 5f, 0f);
	public float speed = 2f;
	
	
	// Use this for initialization
	void Start () {
	destination = new Vector3 (2f, 2f, 0f);
	InvokeRepeating ("SetNewDestination",0f, 8f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation (rigidbody.velocity); //so it faces the right way 
	}
	
	void FixedUpdate(){
		//rigidbody.AddForce (destination - transform.position);
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		rigidbody.AddForce (direction * speed, ForceMode.VelocityChange);
	}
	void SetNewDestination() {
		// set a new destination
		destination = Random.insideUnitSphere * 50f;
		
	}
}
