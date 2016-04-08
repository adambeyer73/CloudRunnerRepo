using UnityEngine;
using System.Collections;

public class Platform_Fall : MonoBehaviour {
    public Collider2D collide;
    public Renderer render;
    public int timer = 0;
    public int maxTimer = 100;
    public bool fadeOut = false;
    public bool fadeIn = false;
	// Use this for initialization
	void Start () {
        //render = GetComponent<Renderer>();
        render.enabled = true;
        collide.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(fadeOut == true)
        {
            timer += 1;
            if (timer >= maxTimer)
            {
                render.enabled = false;
                collide.enabled = false;
                timer = 0;
                fadeIn = true;
                fadeOut = false;
            }

        }

        if(fadeIn == true)
        {
            timer += 1;
            if(timer >= maxTimer)
            {
                render.enabled = true;
                collide.enabled = true;
                timer = 0;
                fadeIn = false;
            }
        }
	}
     void OnCollisionEnter2D (Collision2D other){
        if(other.gameObject.tag == "Player")
        {
            fadeOut = true;
            fadeIn = false;
        }
    }
    
}
