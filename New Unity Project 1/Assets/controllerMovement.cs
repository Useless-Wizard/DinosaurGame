using UnityEngine;
using System.Collections;

public class controllerMovement : MonoBehaviour {


	public float playerSpeed = 1.0f;
	public float turnSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement(){
		float forwardMovement = Input.GetAxis ("Vertical") * playerSpeed * Time.deltaTime;
		float turnMovement = Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime;

		transform.Translate (Vector3.forward * forwardMovement);
		transform.Rotate (Vector3.up * turnMovement);

	}
}
