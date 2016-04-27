using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x += Time.deltaTime / 10f;
        mat.mainTextureOffset = offset;
	}
}
