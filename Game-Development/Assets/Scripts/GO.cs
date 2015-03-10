using UnityEngine;
using System.Collections;

public class GO : MonoBehaviour {

	void OnCollision2DEnter(Collision2D col){
		if (col.gameObject.name == "TempTerrain") {
			SendMessage("Fuck");
		}
	}
	}
