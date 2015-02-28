using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform player;
	float playerHeightY;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		playerHeightY = player.position.y;
		float currentCameraHeight = transform.position.y;
		float newHeightofCamera = Mathf.Lerp (currentCameraHeight,playerHeightY, Time.deltaTime * 10);
		if (playerHeightY > currentCameraHeight) 
		{
			transform.position = new Vector3(transform.position.x, newHeightofCamera, transform.position.z);
		}
		else
		{
			if(playerHeightY < (currentCameraHeight - 5.25f))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
