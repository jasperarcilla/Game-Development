using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	public float speedStart;
	public float increasePerSecond;
	private float secondsElapsed = 0;
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.up * Time.deltaTime * (increasePerSecond * secondsElapsed + speedStart));
		secondsElapsed += Time.deltaTime;
	}
}