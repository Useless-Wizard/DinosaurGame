using UnityEngine;
using System.Collections;

public class playerSize : MonoBehaviour {
	public int score;
	Transform player;
	public int nextState;
	public int size;



	void Awake(){
		player = GetComponent<Transform> ();
		//text = GetComponent <Text>();
		nextState = 5;
		score = 1;
		size = 1;

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			//text.text = "Score: " + score;
		if(Input.GetMouseButtonDown(1)){
			Evolve ();
		}

		if(nextState < score){
			Evolve();
		}
	}

	void Evolve(){
			if(size<6){
				player.localScale += new Vector3 (0.5f, 0, 0.5f);
				nextState *= 2;
				size++;
			}
	}
}
