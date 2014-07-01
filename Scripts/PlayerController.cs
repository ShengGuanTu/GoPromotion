using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; //will show in the inspector & editable
	private int count;
	public GUIText countText;
	public GUIText winText;
	public GUIText beforeText;
	public GUIText afterText;

	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText();
		winText.text = "";
		beforeText.text = "";
		afterText.text = "";
		beforeText.text = "Start: " + count.ToString();
	}

	//For Physics code
	void FixedUpdate () {
		//grab input from keyboard
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);//x, y, z determined the force

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive(false); //deactivate that game object
			beforeText.text = "Before: " + count.ToString();
			count++;
			afterText.text = "After: " + count.ToString();
			SetCountText();
		}

		Destroy(other.gameObject);      //including children components
	}

	void SetCountText (){
		countText.text = "Count: " + count.ToString();
		if(count >= 24){
			winText.text = "YOU WIN!!!!!!";
		}
	}
}


