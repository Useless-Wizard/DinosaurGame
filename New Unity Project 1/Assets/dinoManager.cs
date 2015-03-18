using UnityEngine;
using System.Collections;

public class dinoManager : MonoBehaviour {
	public playerHealth playerHealth;
	public GameObject[] Dinosaur;
	public float spawntime = 3f;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawntime, spawntime);
	}

	void Spawn(){
		if (playerHealth.currentHealth <= 0f) {
						return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int dinosaurIndex = Random.Range (0, Dinosaur.Length);
		Instantiate (Dinosaur[dinosaurIndex], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
