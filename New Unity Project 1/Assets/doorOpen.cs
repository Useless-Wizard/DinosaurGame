using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class doorOpen : MonoBehaviour {
	public enum currentState{
		Active, Inactive,
	}

	private currentState doorState;

	void Start(){
				doorState = currentState.Inactive;
	}


	public void triggerDoor(){
		Debug.Log ("Triggered Door");
		if(!animation.isPlaying){
			switch (doorState){

			case currentState.Active:
				animation.Play ("Close");
				doorState = currentState.Inactive;
				break;
			case currentState.Inactive:
				animation.Play ("Open");
				doorState = currentState.Active;
				break;
			default:
				break;
			}
		}
	}



	public void OnTriggerEnter(Collider Player){
		if(Player.transform.tag == "Player"){
			Debug.Log ("Area Triggered In");
			if(!animation.isPlaying){
				animation.Play ("Open");
			}
		}
	}

	public void OnTriggerExit(Collider Player){
			if(Player.transform.tag == "Player"){
			Debug.Log ("Area Triggered Out");
			if(!animation.isPlaying){
				animation.Play ("Close");
			}
		}
	}
}
