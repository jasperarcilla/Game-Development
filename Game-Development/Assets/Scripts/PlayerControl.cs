 using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


	public float moveSpeed = 4f; 
	// Use this for initialization 
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");  

		rigidbody2D.velocity = new Vector2 (h * moveSpeed, rigidbody2D.velocity.y); 

	}
}
