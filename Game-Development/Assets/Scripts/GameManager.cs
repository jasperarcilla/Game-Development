using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static OnGUI2D OG2D;
	public Transform player;
	float playerHeightY;
	// Use this for initialization

	public Transform regular;
	public Transform jump;
	public Transform leftRight;
	public Transform upDown;

	private int platNumber;
	private float platCheck;
	private float spawnPlaformsTo;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;

		PlatformSpawner (-2.75f);
	}
	
	// Update is called once per frame
	void Update () {
		playerHeightY = player.position.y;

		if (playerHeightY > platCheck) {
			platformManager();
		}

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
				OnGUI2D.OG2D.checkhighscore();
				Application.LoadLevel("GameOver");
			}
		}
	if (playerHeightY > OnGUI2D.score) {
			OnGUI2D.score = (int)playerHeightY;
		}
	}

	void platformManager(){
		platCheck = player.position.y + 15;
		PlatformSpawner (platCheck + 15);
	}

	void PlatformSpawner(float floatvalue){

		float y = spawnPlaformsTo;

		while(y <= floatvalue){
			float x = Random.Range (-6.68f, 6.68f);

			platNumber = Random.Range (1, 5);

			Vector2 posXY = new Vector2(x,y);

			if(platNumber == 1){
				Instantiate (regular,posXY,Quaternion.identity);
			}
			if(platNumber == 2){
				Instantiate (jump,posXY,Quaternion.identity);
			}
			if(platNumber == 3){
				Instantiate (leftRight,posXY,Quaternion.identity);
			}
			if(platNumber == 4){
				Instantiate (upDown,posXY,Quaternion.identity);
			}
			y += Random.Range(.5f,1.75f);
			Debug.Log("Spawn Platform");
		}
		spawnPlaformsTo = floatvalue;
	}
}
