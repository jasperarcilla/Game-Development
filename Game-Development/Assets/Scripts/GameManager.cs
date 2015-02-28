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

	private int platNumber;

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
		platNumber = Random.Range (1, 5);
		if(platNumber == 1){
			Instantiate (regular, new Vector3(x,spawnPoint,0),Quaternion.identity);
		}
		if(platNumber == 2){
			Instantiate (jump, new Vector3(x,spawnPoint,0),Quaternion.identity);
		}
		if(platNumber == 3){
			Instantiate (leftRight, new Vector3(x,spawnPoint,0),Quaternion.identity);
		}
		if(platNumber == 4){
			Instantiate (upDown, new Vector3(x,spawnPoint,0),Quaternion.identity);
		}
	}
}
