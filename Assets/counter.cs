using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class counter : MonoBehaviour {

	public int seconds;
	private float Timer=0.0f;
	public Text TimerBox;
	public bool Counting = true;

	// Use this for initialization
	void Start () {
		seconds = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Counting) {
			Timer += Time.deltaTime;
			seconds = (int)Mathf.Round (Timer);
			TimerBox.text = "" + seconds;
		}
	}
}
