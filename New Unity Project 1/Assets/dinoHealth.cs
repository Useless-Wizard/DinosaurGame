using UnityEngine;
using System.Collections;

public class dinoHealth : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;
	public int scorevalue = 10;


	//BoxCollider boxCollider;
	// public AudioClip deathClip;

	//AudioSource enemyAudio;
	bool isDead;

	void Awake(){
		//boxCollider = GetComponent<boxCollider> ();

		currentHealth = startingHealth; 
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void takeDamage(int amount){
		if(isDead){
			return;
		}

		currentHealth -= amount;

		if(currentHealth<=0){
			currentHealth=0;

			Death();
		}
	}

	void Death(){
		isDead = true;
		Destroy (gameObject);

	}

		//enemyAudio.clip = deathClip;

		//enemyAudio.Play();
}

