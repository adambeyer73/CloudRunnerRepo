using UnityEngine;
using System.Collections;

public class jumping_enemy : MonoBehaviour {

    // Use this for initialization
    int damage = 2;
    int health = 4;
    /* 
     * basic enemies wont jump but we may want 
     * to inherit this script into more advanced enemies
     */
    public float jumppwr = 5.0f;
    public bool has_jump;

    public float walkSpeed = -2.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if there is no more platform to the left of the enemy and the enemy has jump then the enemy should jump
        if (!Physics2D.Raycast(transform.position, (Vector2.down + Vector2.left), 5.0f, 1 << 8) && has_jump)
        {
            //enemy jumps and sets has jump to false so that they only get one jump
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumppwr);
            has_jump = false;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }


    //when the enemy hits the ground they should be able to jump again
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
            has_jump = true;
    }

}
