using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public Transform firePoint;
    public GameObject bullet;
    public GameObject player;
    public Vector3 gunPosition;
    public float gunOffSet;
    public AudioSource bulletSound;

    


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        

	}
	
	// Update is called once per frame
	void Update () {

        if(player.transform.localScale.x > 0)//if the player is facing right
        {
            gunPosition = new Vector3(player.transform.position.x + gunOffSet, player.transform.position.y, player.transform.position.z);//place gun in front of player
            transform.localScale = new Vector3(3f, 3f, 3f);//set gun to be facing same way as player
        }

        else if (player.transform.localScale.x < 0)//if player is facing left
        {
            gunPosition = new Vector3(player.transform.position.x - gunOffSet, player.transform.position.y, player.transform.position.z);//same as above
            transform.localScale = new Vector3(-3f, 3f, 3f);//same as above
        }


        transform.position = gunPosition;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            ////play audio file
            bulletSound.Play();

            Instantiate(bullet, firePoint.position, firePoint.rotation);//instnatiate bullet at position 'firePoint'

            
            
        }


    }
}
