using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
    //if (other.GetComponent<PlayerMove>() == null)
      //  return;
        ScoreManager.AddPoints(pointsToAdd);
    //    GameObject obj = GameObject.FindGameObjectWithTag("Box");
        Destroy(gameObject);
        Destroy(transform.parent.gameObject);
    }
}
