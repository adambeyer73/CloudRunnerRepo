using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Retry(){
		SceneManager.LoadScene (1);
	}

	public void Quit(){
		Application.Quit();
	}
		
}
