using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnCollision2DEnter(Collision2D col){
		if (col.gameObject.name == "TempTerrain") {
			Application.LoadLevel(Application.loadedLevel);		
		}
}
}
