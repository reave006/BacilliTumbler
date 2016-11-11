using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float rotateSpeed =10.0f;
	public float movementSpeed=5.0f;
	private Rigidbody self;
	private bool runOrTumble;

	// Use this for initialization
	void Start () {
		self = GetComponent<Rigidbody> ();
		transform.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("r")) {
			runOrTumble = true;
			//self.AddForce ( transform.up* Time.deltaTime * movementSpeed);
			//transform.position += transform.forward * Time.deltaTime * movementSpeed;
	}
		if (Input.GetKey ("t")) {
			runOrTumble = false;
			//Vector3 rotateDirction = new Vector3 (0, rotateSpeed, 0);
			//transform.Rotate(Vector3.up*rotateSpeed, Space.World);
			//self.AddRelativeTorque(Vector3.right*rotateSpeed);
			//self.AddTorque(Vector3.up*rotateSpeed,ForceMode.Force);
			//self.AddTorque(transform.right * rotateSpeed);
		}

		if (runOrTumble == true) {
			self.AddForce (transform.up * Time.deltaTime * movementSpeed);
		} else {
			self.AddRelativeTorque (Vector3.right * rotateSpeed);
		}

		self.position = new Vector3 (
			self.position.x,
			0.7f,
			self.position.z
		);


	}
}
