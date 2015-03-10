using UnityEngine;
using System.Collections;

public class leftright2d : MonoBehaviour {
	
	float platformspeed = 2f;
	bool endpoint;
	
	// Update is called once per frame
	void Update () {
		if (endpoint) {
			transform.position += Vector3.right * platformspeed * Time.deltaTime;
		} 
		else {
			transform.position -= Vector3.right	* platformspeed * Time.deltaTime;
		}
		if (transform.position.x >= 5.6f) {
			endpoint = false;
				}
		if (transform.position.x <= -5.6f) {
			endpoint = true;
		}
	}
}
