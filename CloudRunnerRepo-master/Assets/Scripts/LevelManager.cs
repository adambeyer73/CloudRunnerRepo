using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	public int pointPenaltyOnDeath;

	private PlayerMove player;

	public HealthManager healthManager;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerMove> ();
		healthManager = FindObjectOfType<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer(){
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		ScoreManager.AddPoints (-pointPenaltyOnDeath);
		healthManager.isDead = false;
	}
}
