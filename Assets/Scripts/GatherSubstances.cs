﻿using UnityEngine;
using System.Collections;

public class GatherSubstances : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag ("glucose"))
		{
			Destroy(other.gameObject);
		}
	}
}
