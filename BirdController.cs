using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour {

	private Animator animator;
	private BoxCollider2D thunderCollider;

	private float counter;
	public float flyingSpeed = 6f;  //1.0f
	private float distance;

	public Transform flyingOrigin;
	public Transform flyingDestination;
	Vector2 flyingAmount;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator> ();
		thunderCollider = GetComponent<BoxCollider2D> ();
	
		distance = Vector3.Distance (flyingOrigin.position, flyingDestination.position);
	}
	
	// Update is called once per frame
	void Update () {

		if (counter < distance) {

			counter += .01f / flyingSpeed;

			Vector3 pointA = flyingOrigin.position;
			Vector3 pointB = flyingDestination.position;


			float x = Mathf.Lerp (0, distance, counter);

			Vector3 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;

			transform.position = pointAlongLine;

		} else {
			
			counter = 0;
			transform.position = flyingOrigin.position;
		}
	}
}
