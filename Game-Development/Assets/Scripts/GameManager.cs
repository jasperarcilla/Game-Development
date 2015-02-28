using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform player;
	float playerHeightY;
	// Use this for initialization

	public Transform regular;
	public Transform jump;
	public Transform leftRight;
	public Transform upDown;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;

		PlatformSpawner (-2.75f);
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
	void PlatformSpawner(float spawnPoint){
		float x = Random.Range (-2.95f, 2.95f);
		Instantiate (jump, new Vector3(x,spawnPoint,0),Quaternion.identity);
	}
}
