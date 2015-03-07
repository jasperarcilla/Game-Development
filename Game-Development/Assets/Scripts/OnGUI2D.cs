using UnityEngine;
using System.Collections;

public class OnGUI2D : MonoBehaviour {
	public static OnGUI2D OG2D;
	public static int score;
	int highscore;
	// Use this for initialization
	void Start () {
		OG2D = this;
		score = 0;
		highscore = PlayerPrefs.GetInt("Highscore1",0);
	}
	void OnGUI(){
		GUI.Label(new Rect(10,10,100,20),"score: " + score);
		GUI.Label (new Rect (10, 30, 100, 20), "highscore: " + highscore);
	}
	public void checkhighscore(){
		if (score > highscore) {
			Debug.Log("Saving Score");
			PlayerPrefs.SetInt("Highscore1",score);
		}
	}
}
