using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;

	private bool paused = false;

	void Start(){

		PauseUI.SetActive (false);
	}
	void Update(){
		if (Input.GetButtonDown ("Pause")) {
			paused = !paused;
		}

		if(paused){
			PauseUI.SetActive(true);
			Time.timeScale = 0;
		}

		if(!paused){
			PauseUI.SetActive(false);
			//set time back to normal time
			Time.timeScale = 1;
		}
	
	}

	public void Resume(){

		paused = false;
	}

	public void Restart(){

		Application.LoadLevel (Application.loadedLevel);
	}

	public void MainMenu(){

		Application.LoadLevel (0);
	}
	//won't actually quit until we build the game
	public void Quit(){

		Application.Quit ();
	}
}
