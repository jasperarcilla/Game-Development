using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class CloseScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		skin = Resources.Load ("GUISkin4") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 50;
		const int buttonHeight = 50;
		
		GUI.skin = skin;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 1.025f - (buttonWidth / 1.8f),
			(2 * Screen.height / 35) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect," "))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
		}
	}
}