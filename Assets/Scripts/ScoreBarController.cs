using UnityEngine;
using System.Collections;

public class ScoreBarController : MonoBehaviour {
	public float decaySpeed;
	private bool shrinking;
	public float turnYellow;
	public float turnRed;
	private Renderer rend;
	public bool Scored;
	public float ScoreAddPerGlucose;
	public GameObject User;
	public AudioSource source;
	public AudioClip deathNoise;

	// Use this for initialization
	void Start () {
		shrinking = true;
		rend = GetComponent<Renderer> ();
		Scored = false;
		rend.material.SetColor ("_Color", Color.green);
	}


	
	// Update is called once per frame
	void Update () {
		if(Scored && transform.localScale.x<=30.0f)
		{
			Vector3 hold = Vector3.right* ScoreAddPerGlucose;
			transform.localScale += hold;
			Scored = false;
		}
		if(shrinking){
			transform.localScale -= Vector3.right * Time.deltaTime * decaySpeed;

			if (transform.localScale.x < .01) {
				shrinking = false;
				User.GetComponent<Mover> ().usercontrol = false;
				source.PlayOneShot (deathNoise);
			}

			if (transform.localScale.x < turnYellow && transform.localScale.x > turnRed) {
				rend.material.SetColor ("_Color", Color.yellow);
			}
			if (transform.localScale.x < turnRed) {
				rend.material.SetColor ("_Color", Color.red);
			} 
			if (transform.localScale.x > turnYellow)
			{
				rend.material.SetColor ("_Color", Color.green);
			}
		}
	}
}
