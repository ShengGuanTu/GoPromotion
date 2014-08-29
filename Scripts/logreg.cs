using UnityEngine;
using System.Collections;

public class logreg : MonoBehaviour 
{
    public static string user = "", name = "", email = "", datb = "";
    private string password = "", rePass = "", message = "";

    private bool register = false;

    private void OnGUI()
    {
        if (message != "")
            GUILayout.Box(message);

        if (register)
        {
			// Make a group on the center of the screen (width not height)
			GUI.BeginGroup (new Rect (2 * Screen.width / 5, Screen.height / 3 + 25, Screen.width / 5, 2 * Screen.height / 3));
			// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
			
			// We'll make a box so you can see where the group is on-screen.
			//GUI.Box (new Rect (0,0,100,100), "Group is here");
			GUI.Label(new Rect(0,0,Screen.width/5,20), "Username");
			user = GUI.TextField(new Rect(0,20,Screen.width/5,30),user);
			GUI.Label(new Rect(0,50,Screen.width/5,20),"Email");
			email = GUI.TextField(new Rect(0,70,Screen.width/5,30),email);
			GUI.Label(new Rect(0,100,Screen.width/5,20),"Password");
			password = GUI.PasswordField(new Rect(0,120,Screen.width/5,30),password, "*"[0]);
			GUI.Label(new Rect(0,150,Screen.width/5,20),"Re-password");
			rePass = GUI.PasswordField(new Rect(0,170,Screen.width/5,30),rePass, "*"[0]);
			GUI.Label(new Rect(0,200,Screen.width/5,20),"Date of Birth");
			datb = GUI.TextField(new Rect(0,220,Screen.width/5,30),datb);
			
			// End the group we started above. This is very important to remember!
			//GUI.EndGroup ();
			// Make a new group below the registration info group


            if (GUI.Button(new Rect(10, 270, Screen.width/16, 30), "Back"))
                register = false;

            if (GUI.Button(new Rect(10 + Screen.width/10, 270, Screen.width/12, 30), "Register"))
            {
                message = "";

                if (user == "" || email == "" || password == "" || datb == "")
                    message += "Please enter all the fields \n";
                else
                {
                    if (password == rePass)
                    {
                        WWWForm form = new WWWForm();
                        form.AddField("user", user);
                        form.AddField("password", password);
						form.AddField("email", email);
						form.AddField("datb", datb);
                        WWW w = new WWW("http://127.0.0.1/register.php", form);
                        StartCoroutine(registerFunc(w));
                    }
                    else
                        message += "Your Password does not match \n";
                }
            }

			GUI.EndGroup ();
        }
        else
        {
			GUI.BeginGroup (new Rect (2 * Screen.width / 5, Screen.height / 3 + 25, Screen.width / 5, 2 * Screen.height / 3));
			GUI.Label(new Rect(0,0,Screen.width/5,20), "User:");
			user = GUI.TextField(new Rect(0,20,Screen.width/5,30), user);
			GUI.Label(new Rect(0,50,Screen.width/5,20), "Password:");
			password = GUI.PasswordField(new Rect(0,70,Screen.width/5,30), password, "*"[0]);

            //GUILayout.BeginHorizontal();

            if (GUI.Button(new Rect(10,120,Screen.width/16,30), "Login"))
            {
                message = "";

                if (user == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    WWWForm form = new WWWForm();
                    form.AddField("user", user);
                    form.AddField("password", password);
                    WWW w = new WWW("http://127.0.0.1/login.php", form);
                    StartCoroutine(login(w));
                }
            }

            if (GUI.Button(new Rect(10+Screen.width/10,120, Screen.width/12, 30), "Register"))
                register = true;

            //GUILayout.EndHorizontal();
			GUI.EndGroup ();
        }
    }

    IEnumerator login(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            if (w.text == "login-SUCCESS")
            {
                //print("WOOOOOOOOOOOOOOO!");
				Application.LoadLevel(1);
            }
            else
                message += w.text;
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
        }
    }

    IEnumerator registerFunc(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            message += w.text;
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
        }
    }
}
