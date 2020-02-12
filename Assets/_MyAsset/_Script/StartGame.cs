using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	public void GameStart (){
		Application.LoadLevel ("Scene1");
	}

	public void GameTutorial (){
		Application.LoadLevel ("Tutorial");
	}

	public void StartMenu (){
		Application.LoadLevel ("Intro");
	}

	public void GameMainMenu (){
		Application.LoadLevel ("MainMenu");
	}

	public void GameQuit (){
		Application.Quit ();
	}
}
