using UnityEngine;
using System.Collections;

public class updown2d : MonoBehaviour {
	
	float platformspeed = 2f;
	bool endpoint;

	float startpoint;
	float endpointY;
	public int unitstomove = 2;
	// Update is called once per frame

	void Start (){
		startpoint = transform.position.y;
		endpointY = startpoint + unitstomove;
		}

	void Update () {
		if (endpoint) {
			transform.position += Vector3.up * platformspeed * Time.deltaTime;
		} 
		else {
			transform.position -= Vector3.up * platformspeed * Time.deltaTime;
		}
		if (transform.position.y >= endpointY) {
			endpoint = false;
		}
		if (transform.position.y <= startpoint) {
			endpoint = true;
		}
	}
}
