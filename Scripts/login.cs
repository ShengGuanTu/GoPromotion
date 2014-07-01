using UnityEngine;
using System.Collections;

public class login : MonoBehaviour {
	//
	private string un = "xitu";
	private string pw = "0628";

	private string usernameString = string.Empty;
	private string passwordString = string.Empty;

	//login box window size
	private Rect windowRect = new Rect(Screen.width / 8, Screen.height / 8, 3 * Screen.width / 4, 3 * Screen.height / 4);
	//private bool correct = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//GUI
	void OnGUI () {
		GUI.Window (0, windowRect, WindowFunction, "LOGIN");
	}

	//
	void WindowFunction(int windowID){
		//User input username
		usernameString = GUI.TextField (new Rect (Screen.width / 5, 2 * Screen.height / 10, Screen.width / 3, Screen.height / 20), usernameString, 10);

		//User input password
		passwordString = GUI.PasswordField (new Rect (Screen.width / 5,  3 * Screen.height / 10, Screen.width / 3, Screen.height / 20), passwordString, "*"[0],10);

		//button
		if (GUI.Button (new Rect (Screen.width / 3, 4 * Screen.height / 10, Screen.width / 10, Screen.height / 16), "Log-in")) {
			if(usernameString == un && passwordString == pw){
				//log-in
				//Debug.Log ("Welcome to Sheng Guan Tu");
				Application.LoadLevel(1);
			}
			else{Debug.Log ("Wrong username or password");}
		}

		GUI.Label (new Rect (Screen.width / 5, 16.5f * Screen.height / 100, Screen.width / 5, Screen.height / 8), "Username");
		GUI.Label (new Rect (Screen.width / 5, 26.5f * Screen.height / 100, Screen.width / 8, Screen.height / 8), "Password");

	}
}












