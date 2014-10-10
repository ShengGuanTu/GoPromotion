using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour
{
    //Booleans for buttons
    bool notesbool = false;
    int notebuttoncount = 0;

    public Texture2D icon;
    public GUIStyle customButton;
    public GUIStyle customButton2;
    public GUIStyle playerFace;
    public GUIStyle buttonBG;
    private string textAreaString = "Write notes here!";



    void Update()
    {
        //Note pad button click ****************************************************************************************************
        if (Input.GetKeyDown(KeyCode.N))
        {
            notesbool = true;
            notebuttoncount += 1;
            if (notebuttoncount % 2 == 0)
            {
                notesbool = false;
            }
        }
        //******************************************************************************************************************************
    }

    void OnGUI()
    {
        GUI.Box(new Rect(-10, -45, 150, 420), "", buttonBG);

        //Buttons displayed on the left side.

        GUI.Button(new Rect(20, 10, 80, 50), "Inventory", customButton);

        GUI.Button(new Rect(20, 60, 80, 50), "Map", customButton);
        GUI.Button(new Rect(20, 110, 80, 50), "Attributes", customButton);

        //Notepad button implementation ******************************************************************************************************************
        if (GUI.Button(new Rect(20, 160, 80, 50), "Notes", customButton))
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
            textAreaString = GUI.TextArea(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 200, 500, 300), textAreaString);
        }
        //****************************************************************************************************************

        GUI.Button(new Rect(20, 210, 80, 50), "Contacts", customButton);
        GUI.Button(new Rect(20, 260, 80, 50), "Available \npositions", customButton);
        GUI.Box(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), "", customButton2);
        GUI.Box(new Rect(Screen.width - 150, Screen.height - 120, 100, 100), "", playerFace);






    }