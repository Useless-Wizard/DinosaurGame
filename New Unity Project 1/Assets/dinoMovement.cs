using UnityEngine;
using System.Collections;

public class dinoMovement : MonoBehaviour {
	Transform player;
	playerHealth playerHealth;
	NavMeshAgent nav;
	playerSize playerSize; 
	//dinoSize dinoSize;
	//public int moveSpeed;
	///public int turnSpeed;
	// Use this for initialization
	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent<playerHealth> ();
		//playerSize = player.GetComponent<playerSize>();
		//dinoSize = GetComponent<dinoSize> ();

		nav = GetComponent<NavMeshAgent> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(playerHealth.currentHealth > 0 /* &&  playerSize.size < dinoSize.size + 1 */){
			nav.SetDestination (player.position);
		}

		/*else if(playerHealth.currentHealth > 0 && playerSize.size> dinoSize.size + 1){
			nav.enabled = false;
			transform.rotation = Quaternion.Slerp (transform.rotation, Quarternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
			transform.position-=transform.forward * moveSpeed * Time.deltaTime;
		}*/
		else{
			nav.enabled = false;
		}
	}
}