 using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


	public float moveSpeed = 4f; 
	// Use this for initialization 
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); 
			transform.eulerAngles = new Vector2(0, 0); //this sets the rotation of the gameobject
		}
		
		if(Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180); //this sets the rotation of the gameobject
		}
		

	}
}
