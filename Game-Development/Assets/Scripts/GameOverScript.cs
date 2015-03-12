using UnityEngine;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
	private GUISkin skin;
	private GUISkin skin1;

	void Start()
	{
		skin = Resources.Load ("GUISkin2") as GUISkin;
		skin1 = Resources.Load ("GUISkin3") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 139;
		const int buttonHeight = 42;

		GUI.skin = skin;

		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			" "
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Jumper");
		}
		Menu ();

	}
	void Menu()
	{
		const int buttonWidth = 139;
		const int buttonHeight = 42;

		GUI.skin = skin1;

		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			" "
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Menu");
		}
	}
}