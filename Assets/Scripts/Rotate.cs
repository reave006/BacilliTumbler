using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed=1.0f;
	public bool rotateDirection=true;
	private Vector3 direction;
	private Rigidbody self;
	// Use this for initialization
	void Start () {
		self = transform.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rotateDirection == true) {
			direction = Vector3.up;
		} else {
			direction = -Vector3.right;
		}
		transform.Rotate (0, speed / Time.deltaTime, 0);
		//transform.Rotate (direction, Space.Self);	
		//self.AddRelativeTorque (direction, ForceMode.Force);
		//transform.RotateAround(transform.position, direction, Time.deltaTime * speed);
	}
}
