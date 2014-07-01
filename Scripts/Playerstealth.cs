using UnityEngine;
using System.Collections;

public class Playerstealth : MonoBehaviour {

	void Start () {
	
	}


	public float speed;

	//For Physics code
	void FixedUpdate () {
		//grab input from keyboard
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);//x, y, z determined the force
		
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

}
