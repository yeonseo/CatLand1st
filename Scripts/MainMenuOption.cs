using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuOption : MonoBehaviour {
	public static bool isLoading = false;

	public void newGame() {
		SceneManager.LoadScene(2);
	}

	public void loadGame() {
		isLoading = true;
		SceneManager.LoadScene(2);
	}


}