using UnityEngine;
using System.Collections;

public class Fallout : MonoBehaviour {

	public int lives = 2;
	public Transform respawn;
	public Transform fallout;
	public GameObject gameObject;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform == fallout) {
			transform.position = respawn.position;
			lives -= 1;
		}
	}

}
