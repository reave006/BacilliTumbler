using UnityEngine;
using System.Collections;

public class Rotate2 : MonoBehaviour {
	public float speed=1.0f;
	public bool rotateDirection=true;
	private Vector3 direction;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (rotateDirection == true) {
			direction = Vector3.up;
		} else {
			direction = -Vector3.right;
		}

		transform.RotateAround(transform.position, Vector3.back, Time.deltaTime * speed);
	}
}