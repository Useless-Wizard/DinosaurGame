using UnityEngine;
using System.Collections;

public class dinoAttack : MonoBehaviour {
	public float timeBetweenAttacks = .5f;
	public int attackDamage = 10;

	GameObject player;
	playerHealth playerHealth;
	playerSize playerSize;
	bool playerInRange;
	bool dinoLarger;
	bool playerLarger;
	float timer;
	dinoSize dinoSize;
	dinoHealth dinoHealth;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <playerHealth> ();
		playerSize = player.GetComponent<playerSize> ();
		dinoSize = GetComponent<dinoSize> ();
		dinoHealth = GetComponent<dinoHealth> ();

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			playerInRange = true;

			if(dinoSize.size > playerSize.size + 1){
				dinoLarger = true;
			}
			else if(dinoSize.size + 1 < playerSize.size){
				playerLarger = true;
			}
		}
	}



	void OnTriggerExit(Collider other){
		if (other.gameObject == player) { 
			playerInRange = false;
			dinoLarger = false;
			playerLarger = false;
				}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if(timer >= timeBetweenAttacks && playerInRange && !dinoLarger && !playerLarger && dinoHealth.currentHealth>0){
			Attack();
		}

		else if(timer >= timeBetweenAttacks && playerInRange && dinoLarger && dinoHealth.currentHealth>0){
			Trample();

		}//makes player immune to damage by neglecting to call attack script
		else if(timer >= timeBetweenAttacks && playerInRange && !dinoLarger && playerLarger && dinoHealth.currentHealth>0){
			getTrampled();
		}
	}

	void Attack(){
		timer = 0f;
		if(playerHealth.currentHealth > 0){
			playerHealth.TakeDamage(attackDamage);
		}
	}

	void Trample(){
		timer = 0f;
		if(playerHealth.currentHealth > 0){
			playerHealth.TakeDamage (50);
		}
	}
	//makes player immune to damage
	void getTrampled(){
		timer = 0f;
	}
}
	

