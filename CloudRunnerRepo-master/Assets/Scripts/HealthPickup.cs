using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {
    public int healthToGive;
    public AudioSource pickupSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	
	}

    void OnTriggerEnter(Collider other)
    {
    //   if (other.GetComponent<PlayerMove>() == null)
  //   return;
    
        HealthManager.HurtPlayer(-healthToGive);
     //   GameObject obj = GameObject.FindGameObjectWithTag("Box");
        Destroy(gameObject);
        Destroy(transform.parent.gameObject);
     
    }
}
