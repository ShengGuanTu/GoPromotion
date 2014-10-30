using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class GUI : MonoBehaviour
{
    //Booleans/counters for buttons
    bool notesbool = false;
    int notebuttoncount = 0;
    bool inventorybool = false;
    int inventorypushcount = 0;
    bool mapbool = false;
    int mappushcount = 0;
    bool contactsbool = false;
    int contactspushcount = 0;

    //Misc. Variables
    public Texture2D icon;
    public GUIStyle customButton;
    public GUIStyle customButton2;

    //Inventory button 
    public GUIStyle inventoryButton;
    public GUIStyle inventory;



    //Map button
    public GUIStyle mapButton;
    public GUIStyle map;
    public GUIStyle mapBG;


    public GUIStyle contacts;
    public GUIStyle attributes;

    //NotePad Button
    public GUIStyle noteButton;
    public GUIStyle Notepad;
    private string textAreaString = "Write notes here!";

    //Misc.
    public GUIStyle playerFace;
    public GUIStyle buttonBG;



    void Update()
    {
        //Note pad button click ****************************************************************************************************
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("received character N");
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
            Debug.Log("received character I");
            inventorybool = true;
            inventorypushcount += 1;
            if (inventorypushcount % 2 == 0)
            {
                inventorybool = false;
            }
        }

        //Map Button Click**************************************************************************************************************
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("received character M");
            mapbool = true;
            mappushcount += 1;
            if (mappushcount % 2 == 0)
            {
                mapbool = false;
            }
        }
        //**************************************************************************************************************************

        //Contacts Button Click*****************************************************************************************************
        if (Input.GetKeyDown(KeyCode.C))
        {
            contactsbool = true;
            contactspushcount += 1;
            if (contactspushcount % 2 == 0)
            {
                contactsbool = false;
            }
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(-10, -45, 150, 420), "", buttonBG);

        //Buttons displayed on the left side.*********************************************************************************************************

        //Inventory button implementation
        if (GUI.Button(new Rect(20, 10, 80, 50), "", inventoryButton))
        {
            inventorybool = true;
            inventorypushcount += 1;
            if (inventorypushcount % 2 == 0)
            {
                inventorybool = false;
            }

        }
        if (inventorybool == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 200, 300, 400), "", inventory);
        }

        //End of inventory button implementation********************************************************************************



        //Map button implementation
        if (GUI.Button(new Rect(20, 60, 80, 50), "", mapButton))
        {
            mapbool = true;
            mappushcount += 1;
            if (mappushcount % 2 == 0)
            {
                mapbool = false;
            }
        }
        if (mapbool == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 325, Screen.height / 2 - 230, 650, 450), "", mapBG);
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 200, 600, 400), "", map);


        }
        //End of map button implementation*************************************************************************************


        GUI.Button(new Rect(20, 110, 80, 50), "Attributes", customButton);

        //Notepad button implementation 
        if (GUI.Button(new Rect(20, 160, 80, 50), "", noteButton))
        {
            notesbool = true;
            notebuttoncount += 1;
            if (notebuttoncount % 2 == 0)
            {
                notesbool = false;
            }
        }
        if (notesbool == true)
        {
            textAreaString = GUI.TextArea(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 200, 500, 300), textAreaString, Notepad);
        }
        //End of Notepad button implementation***************************************************************************************

        //Contact Button Implementation
        if (GUI.Button(new Rect(20, 210, 80, 50), "Contacts", customButton))
        {
            contactsbool = true;
            contactspushcount += 1;
            if (contactspushcount % 2 == 0)
            {
                contactsbool = false;
            }
        }
        if (contactsbool == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 200, 300, 400), "", contacts);
        }

        //End of Contacts Button Implementation*********************************************************************************
        GUI.Button(new Rect(20, 260, 80, 50), "Available \npositions", customButton);
        GUI.Box(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), "", customButton2);
        GUI.Box(new Rect(Screen.width - 150, Screen.height - 120, 100, 100), "", playerFace);






    }

}
=======
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
>>>>>>> 917e0f92b6050a72518ff292bcf397aefd385448
