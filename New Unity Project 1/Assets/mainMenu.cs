 using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public GUISkin guiSkin;

	void OnGUI(){
		if(GUI.Button (new Rect((Screen.width * 0.5f) - (Screen.width * 0.1f) ,(Screen.height * 0.5f) - (Screen.height * 0.1f), Screen.width * 0.2f ,Screen.height* 0.1f), "Play")){
			Application.LoadLevel ("test");
		}

		if(GUI.Button(new Rect((Screen.width * 0.5f) - (Screen.width * 0.1f), (Screen.height * 0.7f) - (Screen.height * 0.1f), Screen.width * 0.2f, Screen.height * 0.1f), "Quit")){
			Application.Quit();
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
