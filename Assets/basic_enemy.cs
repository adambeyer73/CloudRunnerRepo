using UnityEngine;
using System.Collections;

public class basic_enemy : MonoBehaviour {

	// Use this for initialization
    int damage = 2;
    int health = 4;
    /* 
     * basic enemies wont jump but we may want 
     * to inherit this script into more advanced enemies
     */
    private float localYVelocity = 0.0f;
    double jumppwr;

    public float walkSpeed = 1.0f;
    public float wallLeft = 0.0f;
    public float wallRight = 5.0f;
    float walkingDirection = 1.0f;
    Vector2 walkAmount;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	     walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
    if (!Physics2D.Raycast(transform.position, (Vector2.down + Vector2.right),5.0f, 1) && walkingDirection == 1.0f)
         walkingDirection = -1.0f;
    else if (!Physics2D.Raycast(transform.position, (Vector2.down + Vector2.left), 5.0f, 1) && walkingDirection == -1.0f)
         walkingDirection = 1.0f;
     transform.Translate(walkAmount);
	}
}
