using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
   private Rigidbody2D rigidbody;
   public float speed;
   Animation animation;
//   public GameObject MAX;

   float moveHorizontal, moveVertical;
   Vector2 movement;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animation>();
        animation.Play("idle");
        movement = new Vector2(0.0f, 0.0f);
    
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
            animation.Play("jump");
        }

        else if (Input.GetKey("space"))
        {
            animation.Play("flip");
        }

        else if (Input.GetKey("down"))
            {
               animation.Play("walk");
               speed = 0.5f;
              moveHorizontal = (rigidbody.gameObject.transform.position.x) + 0.5f;
              rigidbody.velocity = (movement * speed) * -1;

               transform.position = new Vector3((transform.position.x + 0.25f), 0f, 0f); 

            }
   
         
        else if (Input.GetKey("right"))
        {
            animation.Play("run");
         moveHorizontal = (rigidbody.gameObject.transform.position.x)+1.0f;

             speed = 1f;
           movement = new Vector2(moveHorizontal, 0.0f);

          rigidbody.velocity = (movement * speed)*-1;
           
         transform.position = new Vector3((transform.position.x+0.5f),0f,0f); 
            
          
        }
       // speed = 0f;
        else
        {
            rigidbody.velocity = new Vector2(0f,0f); 
          
            animation.Play("idle");
        }
             


      
            
	}

    void FixedUpdate()
    {

          


 
    }
}
