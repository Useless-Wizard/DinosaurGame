using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rayAttack : MonoBehaviour {

	public int damageAttack = 10;
	//public float timeBetweenBites = 0.15f;
	public float range = 2.5f;


	//float timer;
	Ray shootRay;
	RaycastHit shootHit;
	GameObject player;
	playerSize playerSize;
	playerHealth playerHealth;
	public Slider healthSlider;

	//AudioSource biteAudio;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerSize = player.GetComponent<playerSize> ();
		playerHealth = player.GetComponent<playerHealth> ();
		//biteAudio = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//timer += Time.deltaTime;

		if(Input.GetMouseButtonDown(0)){// && timer >= timeBetweenBites){
			Bite();
		}
	}

	void Bite(){
		Debug.Log ("Line Cast");
		//timer = 0f;

		//biteAudio.Play();

		shootRay.origin = transform.position;
		shootRay.direction = transform.forward;

		if(Physics.Raycast(shootRay, out shootHit, range)){
			dinoHealth healthDamage = shootHit.collider.GetComponent<dinoHealth>();
			dinoSize dinoSize = shootHit.collider.GetComponent<dinoSize>();
			dinoHealth currentHealth = shootHit.collider.GetComponent<dinoHealth>();


			if(healthDamage != null && dinoSize.size <= playerSize.size + 1){
				Debug.Log ("HIT THE ENEMY!");
				if(playerSize.size > dinoSize.size + 1){
					healthDamage.takeDamage (50);
						if(currentHealth.currentHealth <=0){
							playerHealth.currentHealth += 10;
							healthSlider.value = playerHealth.currentHealth;
							playerSize.score += 1;

							if(playerHealth.currentHealth > playerHealth.startingHealth){
								playerHealth.currentHealth = playerHealth.startingHealth;
						}
					}
				}
				else{
					healthDamage.takeDamage(damageAttack);
						if(currentHealth.currentHealth <=0){
							playerHealth.currentHealth += 10;
							healthSlider.value = playerHealth.currentHealth;
							playerSize.score += 1;

							if(playerHealth.currentHealth > playerHealth.startingHealth){
								playerHealth.currentHealth = playerHealth.startingHealth;
							}
						}
				}
			}
		}
	}
}