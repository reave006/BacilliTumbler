using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mover : MonoBehaviour {
	
	public float rotateSpeed =10.0f;
	public float movementSpeed=5.0f;
	public GameObject SubstanceManger;
	private Rigidbody self;
	private bool runOrTumble;
	public GameObject scoreBar;
	private int count;
	public bool usercontrol;
	public float vanishingSpeed;
	private bool here;
	public AudioSource source;
	public AudioClip eating;
	public Text textbox;


	// Use this for initialization
	void Start () {
		self = GetComponent<Rigidbody> ();
		transform.gameObject.SetActive (true);
		usercontrol = true;
		here = true;
		//source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (usercontrol) {
			if (Input.GetKey ("r")) {
				runOrTumble = true;
			}

			if (Input.GetKey ("t")) {
				runOrTumble = false;
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
		} else {

			if (here) {
				GameObject.Find ("background").SetActive (false);
				textbox.GetComponent<counter>().Counting = false;
				transform.GetComponent<Rigidbody> ().useGravity = true;
				here = false;
			}

			runOrTumble = false;

			if (transform.position.y > -25.0f) {
				self.AddRelativeTorque (Vector3.right * 200 * Time.deltaTime);
			} else {
				SceneManager.LoadScene ("StartPage");
			}
		}
			
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("glucose")) {
			source.PlayOneShot (eating);
			other.gameObject.SetActive (false);
			Destroy (other.gameObject);
			SubstanceManger.GetComponent<GatherableObjectMaker> ().numberOfObjects = SubstanceManger.GetComponent<GatherableObjectMaker> ().numberOfObjects - 1;
			scoreBar.GetComponent<ScoreBarController> ().Scored = true;
		}
	}
}

