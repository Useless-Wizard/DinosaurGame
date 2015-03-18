using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiScore : MonoBehaviour {
	GameObject player;
	playerSize playerSize;
	Text text; 
	
	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerSize = player.GetComponent<playerSize> ();
		text = GetComponent<Text> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Dino Stage: " + playerSize.size + " of 6\r\nScore: " + playerSize.score;
	}
}
