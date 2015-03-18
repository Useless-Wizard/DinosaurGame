using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public playerHealth playerHealth;
	public float restartDelay = 5f;
	//AudioClip

	Animator anim;
	float restartTimer;

	void Awake(){
		anim = GetComponent<Animator>();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(playerHealth.currentHealth <= 0){
			anim.SetTrigger ("GameOver");

			restartTimer += Time.deltaTime;

			if(restartTimer >= restartDelay){
				Application.LoadLevel("MenuScreen");
			}
		}
	}
}
