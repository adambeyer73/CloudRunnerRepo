using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Title_Menu : MonoBehaviour {

	// Use this for initialization
    public string startlvl;
	void Start () {
	
	}

    public void startGame()
    {
        //Application.LoadLevel(startlvl);
        SceneManager.LoadScene(1);
    }
    public void lvlSelect()
    {
        Application.Quit();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
