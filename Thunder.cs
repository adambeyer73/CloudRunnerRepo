using UnityEngine;
using System.Collections;

public class Thunder : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float distance;

	public Transform origin;
	public Transform destination;
	public Transform colliderCenter;

	public float lineDrawingSpeed = 6f;

	private BoxCollider thunderCollider;

	// Use this for initialization
	void Start () {
	
		thunderCollider = GetComponent<BoxCollider> ();
		lineRenderer = GetComponent<LineRenderer>();

		//0 for line number, coordinates
		lineRenderer.SetPosition (0, origin.position);

		distance = Vector3.Distance (origin.position, destination.position);

	}
	
	// Update is called once per frame
	void Update () {

		if (counter < distance) {
			
			counter += .1f / lineDrawingSpeed;
	
			Vector3 pointA = origin.position;
			Vector3 pointB = destination.position;


			float x = Mathf.Lerp (0, distance, counter);

			Vector3 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;

			lineRenderer.SetPosition (1, pointAlongLine);

			Vector3 v = lineRenderer.bounds.size;
			thunderCollider.size = v;


		} else {

			counter = 0;
		}
	}
}
