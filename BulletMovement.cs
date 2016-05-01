using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    public GameObject player;
    public float speed;
    public PlayerMove playerMove;
    public GameObject bullet;
    public Vector2 zero = new Vector2(0, 0);

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {


        if (player.transform.localScale.x > 0 && bullet.GetComponent<Rigidbody2D>().velocity.Equals(zero))
        {
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else if (player.transform.localScale.x < 0 && bullet.GetComponent<Rigidbody2D>().velocity.Equals(zero))
        {
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((speed*-1), 0);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}
