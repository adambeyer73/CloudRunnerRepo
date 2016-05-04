using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public int maxPlayerHealth;
	public static int playerHealth;
	//Text text;
	private LevelManager levelManager;
	public bool isDead;
    public Slider healthBar;
	void Start(){
	//	text = GetComponent<Text> ();
        healthBar = GetComponent<Slider>();
		playerHealth = maxPlayerHealth;

		levelManager = FindObjectOfType<LevelManager> ();
		isDead = false;
	}

	void Update(){
		if (playerHealth <= 0 && !isDead) {
			playerHealth = 0;
			levelManager.RespawnPlayer ();
			isDead = true;
		}
        if (playerHealth > maxPlayerHealth)
            playerHealth = maxPlayerHealth;
	//	text.text = "" + playerHealth;
        healthBar.value = playerHealth;
        
	}

	public static void HurtPlayer(int damageToGive){
		playerHealth -= damageToGive;
		if (playerHealth <= 0) {
			SceneManager.LoadScene (2);		
		}
	}

}
