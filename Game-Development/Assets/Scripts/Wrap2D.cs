﻿using UnityEngine;
using System.Collections;

public class Wrap2D : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void FixedUpdate () {

		if (transform.position.x <= -6.68f) {

						transform.position = new Vector3 (6.68f, transform.position.y, transform.position.z);
		
				} 
		else if (transform.position.x >= 6.68f) {
				
						transform.position = new Vector3 (-6.68f, transform.position.y, transform.position.z);
				}
	
	}
}
