using UnityEngine;
using System.Collections;

public class PlayerJump2D : MonoBehaviour {

	public bool grounded;
	public float jumpHeight = 500f;

	public Transform groundcheck;

	public float groundRadius = .2f;
	public LayerMask ground;

	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
	
		grounded = Physics2D.OverlapCircle(groundcheck.position, groundRadius, ground);

		float velY = rigidbody2D.velocity.y;


		if (grounded && velY <= 0 ) {
						rigidbody2D.velocity = new Vector2 (0, 0);

						rigidbody2D.AddForce (new Vector2 (0, jumpHeight));
				}
	}
}
