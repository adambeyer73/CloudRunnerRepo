using UnityEngine;
using System.Collections;

public class PlayerGunScript : MonoBehaviour {

    Vector3 mousePosition;
    GameObject playerGun;

    void Start ()
    {
         mousePosition = Input.mousePosition;
         playerGun = GameObject.Find("Player Gun"); //find better way to get handle for the gun possibly
    }
	
	
	// Update is called once per frame
	void Update ()
    {
        playerGun.transform.Rotate(mousePosition.y, 0, 0);
	}
}
