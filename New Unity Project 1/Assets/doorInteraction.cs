using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Animation))]
public class doorInteraction : MonoBehaviour {
	public enum eInteractiveState{
		Active, Inactive,
	}

	private eInteractiveState m_state;

	void Start(){
		m_state = eInteractiveState.Inactive;
	}

	public void triggerDoor(){
		Debug.Log("Triggered Door");
		if(!animation.isPlaying){
			switch (m_state){
			
			case eInteractiveState.Active:
				animation.Play ("doorClose");
				m_state = eInteractiveState.Inactive;
				break;
			case eInteractiveState.Inactive:
				animation.Play ("doorOpen");
				m_state = eInteractiveState.Active;
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
				animation.Play("doorOpen");
			}
		}
	}

	public void OnTriggerExit(Collider Player){
		if(Player.transform.tag == "Player"){
			Debug.Log ("Area Triggered Out");
			if(!animation.isPlaying){
				animation.Play ("doorClose");
			}
		}
	}
}