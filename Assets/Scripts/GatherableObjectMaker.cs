using UnityEngine;
using System.Collections;

public class GatherableObjectMaker : MonoBehaviour {

	private float x;
	private float y;
	private float z;
	private int maxNumberOfObjects=10;
	public int numberOfObjects=0;
	public float radius;
	private float negradius;
	public GameObject Substance;
	// Use this for initialization

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (numberOfObjects <= maxNumberOfObjects) {
			negradius = radius * -1;
			x = Random.Range (negradius, radius);
			z = Random.Range (negradius, radius);
			y = 0.5f;
			numberOfObjects++;
			Vector3 location = new Vector3 (x, y, z);
			Instantiate (Substance.gameObject, location, Quaternion.identity);
		}
	}
}
