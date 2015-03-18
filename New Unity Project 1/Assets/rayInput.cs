using UnityEngine;
using System.Collections;

public class rayInput : MonoBehaviour {
	//inheritance
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			
			if(Physics.Raycast(rayOrigin.origin, rayOrigin.direction, out hitInfo, Mathf.Infinity)){
				Debug.Log ("Click");
				doorInteraction door = hitInfo.collider.GetComponent<doorInteraction>();
				if(door){
					door.triggerDoor();
				}
			}
		}
	}
}