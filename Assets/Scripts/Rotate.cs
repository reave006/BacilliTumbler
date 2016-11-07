using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed=1.0f;
	public bool rotateDirection=true;
	private Vector3 direction;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rotateDirection == true) {
			direction = Vector3.right;
		} else {
			direction = -Vector3.right;
		}
			
		transform.RotateAround(transform.position, direction, Time.deltaTime * speed);
	}
}
