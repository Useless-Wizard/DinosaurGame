using UnityEngine;
using System.Collections;

public class rayHandler : MonoBehaviour {

	void Update () {
		if(Input.GetMouseButtonDown (0)){
			Ray rayOrigin = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo;

			if(Physics.Raycast(rayOrigin.origin, rayOrigin.direction, out hitInfo, Mathf.Infinity)){
				Debug.Log ("Click");
				doorOpen door = hitInfo.collider.GetComponent<doorOpen>();
				if(door){
					door.triggerDoor();
				}
			}
		}
	}
}
