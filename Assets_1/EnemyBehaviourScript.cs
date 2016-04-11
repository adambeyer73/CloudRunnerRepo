using UnityEngine;
using System.Collections;

public class EnemyBehaviourScript : MonoBehaviour {
    private Rigidbody rigidbody;
    public float tilt;
    Animation animation;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        animation = GetComponent<Animation>();
        animation.Play("Attack");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
