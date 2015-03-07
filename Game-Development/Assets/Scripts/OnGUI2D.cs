using UnityEngine;
using System.Collections;

public class OnGUI2D : MonoBehaviour {

	public static int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	void OnGUI(){
		GUI.Label(new Rect(10,10,100,20),"score: " + score);
	}
}
