using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	//public AudioClip deathClip;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	controllerMovement playerMovement;

	bool isDead;
	bool damaged;

	void Awake(){
		playerMovement = GetComponent<controllerMovement>();
		currentHealth = startingHealth;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(damaged){
			damageImage.color = flashColour;
		}
		else{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}

	public void TakeDamage(int amount){
		damaged = true;

		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if(currentHealth <= 0 && !isDead){
			Death();
		}
	}

	void Death(){
		isDead = true;
		currentHealth=0;
		//playerAudio.clip = deathClip;
		//playerAudio.Play();

		playerMovement.enabled = false;
		//player shooting.enabled = false;

		Destroy (gameObject);
	}
}
