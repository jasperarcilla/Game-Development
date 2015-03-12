using UnityEngine;
using System.Collections;

public class JumpPlat2D : MonoBehaviour {

	public float jumpHeight = 500;
	public AudioClip audioClip;
	float VelY;
	// Update is called once per frame
	void Update () {
		VelY = rigidbody2D.velocity.y;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "JumpPlat" && VelY <= 0)
		{
			rigidbody2D.velocity = new Vector2(0,0);
			rigidbody2D.AddForce(new Vector2(0,jumpHeight));
			audio.clip = audioClip;
			audio.Play();
		}
	}
}
