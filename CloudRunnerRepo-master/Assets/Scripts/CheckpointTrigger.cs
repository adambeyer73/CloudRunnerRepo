using UnityEngine;
using System.Collections;

public class CheckpointTrigger : MonoBehaviour {

	public bool isTriggered;

	void onTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			isTriggered = true;
		}
	}
}
