using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
	private GUISkin skin;

	void Start()
	{
		skin = Resources.Load ("GUISkin") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 139;
		const int buttonHeight = 42;

		GUI.skin = skin;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 1.8f),
			(2 * Screen.height / 4.8f) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect," "))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Jumper");
		}
	}
}