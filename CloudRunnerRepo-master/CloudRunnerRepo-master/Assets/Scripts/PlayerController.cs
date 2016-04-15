using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
   private Rigidbody rigidbody;
   public float speed = 3.0f;
   public float tilt;
   Animation animation;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        animation = GetComponent<Animation>();
        animation.Play("idle");
        
	}
	
	// Update is called once per frame
	void Update () {
	
        
  
        

            
	}

    void FixedUpdate()
    {
            float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement  = new Vector3 (moveHorizontal, 0.0f, moveVertical);
              if (Input.GetKey("up"))
            animation.Play("jump");

        if (Input.GetKey("down"))
            animation.Play("walk");
        if (Input.GetKey("space"))
            animation.Play("flip");
        if (Input.GetKey("right"))
        {
            animation.Play("run");
            CloudFlow.m_MaxSpeed = 5;
            CloudFlow.m_MinSpeed = 5; 
         // rigidbody.velocity = movement * speed;
        }


    

    //    rigidbody.position =new Vector3 (x, y, z);
 
    }
}
