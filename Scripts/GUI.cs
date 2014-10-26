using UnityEngine;
using System.Collections;

public class IO: MonoBehaviour {

	//Booleans/counters for buttons
	bool notesbool = false;
	int notebuttoncount = 0;
	bool inventorybool = false;
	int inventorypushcount = 0;
	bool mapbool = false;
	int mappushcount = 0;
	bool attributebool = false;
	int attributepushcount = 0;
	
	//Misc. Variables
	public Texture2D icon;
	public GUIStyle customButton;
	public GUIStyle customButton2;
	public GUIStyle inventory;
	public GUIStyle playerFace;
	public GUIStyle buttonBG;
	public GUIStyle map;
	public GUIStyle mapBG;
	private string textAreaString = "Write notes here!";

	void Update()
	{
		//Note pad button click ****************************************************************************************************
		if (Input.GetKeyDown(KeyCode.N))
		{
			Debug.Log ("received character N");
			notesbool = true;
			notebuttoncount += 1;
			if (notebuttoncount % 2 == 0)
			{
				notesbool = false;
			}
		}
		//******************************************************************************************************************************
		//Inventory Button Click********************************************************************************************************
		if (Input.GetKeyDown(KeyCode.I))
		{
			Debug.Log ("received character I");
			inventorybool = true;
			inventorypushcount += 1;
			if (inventorypushcount % 2 == 0)
			{
				inventorybool = false;
			}
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			Debug.Log ("received character J");
			mapbool = true;
			mappushcount += 1;
			if (mappushcount % 2 == 0)
			{
				mapbool = false;
			}
		}
	}
	
	void OnGUI()
	{
		GUI.Box (new Rect (0, 0, Screen.width, Screen.height), "", buttonBG);

		//Buttons displayed on the left side.*********************************************************************************************************

		//Inventory button implementation
		if (GUI.Button (new Rect (10, 1*Screen.height/7, Screen.width/7,Screen.height/7), "Inventory", customButton)) {
			inventorybool = true;
			inventorypushcount += 1;
			if (inventorypushcount % 2 == 0) {
					inventorybool = false;
			}
	
		}
		if (inventorybool == true) {
			GUI.Box (new Rect (Screen.width / 2 - 200, Screen.height / 2 - 250, 400, 500), "Inventory", inventory);
		}

		//End of inventory button implementation********************************************************************************



		//Map button implementation
		if (GUI.Button (new Rect (10, 2*Screen.height/7, Screen.width/7,Screen.height/7), "Map", customButton)) {
			mapbool = true;
			mappushcount += 1;
			if (mappushcount % 2 == 0) {
					mapbool = false;
			}
		}
		if (mapbool == true) {
				GUI.Box (new Rect (Screen.width / 2 - 325, Screen.height / 2 - 230, 650, 450), "", mapBG);
				GUI.Box (new Rect (Screen.width / 2 - 300, Screen.height / 2 - 200, 600, 400), "", map);
	
	
		}
		//End of map button implementation*************************************************************************************
		GUI.Button (new Rect (10, 3*Screen.height/7, Screen.width/7,Screen.height/7), "Attributes", customButton);

		//Notepad button implementation 
		if (GUI.Button (new Rect (10, 4*Screen.height/7, Screen.width/7,Screen.height/7), "Notes", customButton)) {
			notesbool = true;
			notebuttoncount += 1;
			if (notebuttoncount % 2 == 0) {
					notesbool = false;
			}
		}
		if (notesbool == true) {
				textAreaString = GUI.TextArea (new Rect (Screen.width / 2 - 200, Screen.height / 2 - 250, 400, 500), textAreaString);
		}
		//End of Notepad button implementation***************************************************************************************

		//GUI.Button(new Rect(20, 210, 80, 50), "Contacts", customButton);
		//GUI.Button(new Rect(20, 260, 80, 50), "Available \npositions", customButton);
		GUI.Box(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), "", customButton2);
		GUI.Box(new Rect(Screen.width - 150, Screen.height - 120, 100, 100), "", playerFace);

	}
}	
