using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public Transform firePoint;
    public GameObject bullet;
    public GameObject player;
    public Vector3 gunPosition;
    public float gunOffSet;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        gunPosition = new Vector3 (player.transform.position.x + gunOffSet, player.transform.position.y, player.transform.position.z);
        transform.position = gunPosition;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }


    }
}
