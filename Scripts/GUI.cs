using UnityEngine;
using System.Collections;

public class gui1 : MonoBehaviour
{

    public Texture2D icon;
    public GUIStyle customButton;
    public GUIStyle customButton2;
    public GUIStyle playerFace;
    public GUIStyle buttonBG;


    void OnGUI()
    {
        GUI.Box(new Rect(-10, -45, 150, 420), "", buttonBG);
        //Buttons displayed on the left side.
   
        GUI.Button(new Rect(20, 10, 80, 50 ), "Inventory", customButton);

        GUI.Button(new Rect(20, 60, 80, 50), "Map", customButton);
        GUI.Button(new Rect(20, 110, 80, 50), "Attributes", customButton);
        GUI.Button(new Rect(20, 160, 80, 50), "Notes", customButton);
        GUI.Button(new Rect(20, 210, 80, 50), "Contacts", customButton);
        GUI.Button(new Rect(20, 260, 80, 50), "Available \npositions", customButton);
        GUI.Box(new Rect(Screen.width - 200, Screen.height - 200, 200, 200),"", customButton2);
        GUI.Box(new Rect(Screen.width - 150, Screen.height - 120, 100, 100), "", playerFace);
        
        /*
        GUI.Button(new Rect(10, 90, 75, 35), new GUIContent("Attribute", icon));
        GUI.Button(new Rect(10, 130, 75, 35), new GUIContent("Notes", icon));
        GUI.Button(new Rect(10, 170, 75, 35), new GUIContent("Contacts", icon));
        GUI.Button(new Rect(10, 210, 75, 35), new GUIContent("Available \npositions", icon));
          */

    }

}