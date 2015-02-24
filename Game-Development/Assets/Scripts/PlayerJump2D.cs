using UnityEngine;
using System.Collections;

public class PlayerJump2D : MonoBehaviour {

	public bool grounded;
	public float jumpheight = 500f;

	public Transform groundcheck;

	float groundRadius = .2f;
	public LayerMask ground;

	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
	
		grounded = Physics2D.OverlapCircle (groundcheck.position, groundRadius, ground);

	}
}
