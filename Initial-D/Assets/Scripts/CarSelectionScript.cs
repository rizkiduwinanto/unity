using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelectionScript : MonoBehaviour {
	public static int color;
	public string mScene;

	void Start(){
		mScene = PlayerPrefs.GetString("Scene", "DownValley");
	}

	public void playGreen() {
		color = 3;
		if (mScene == "DownValley") {
			SceneManager.LoadScene (5);
		} else {
			SceneManager.LoadScene (4);
		}
	}

	public void playRed(){
		color = 1;
		if (mScene == "DownValley") {
			SceneManager.LoadScene (5);
		} else {
			SceneManager.LoadScene (4);
		}
	}

	public void playBlue(){
		color = 2;
		if (mScene == "DownValley") {
			SceneManager.LoadScene (5);
		} else {
			SceneManager.LoadScene (4);
		}
	}

	public void doBack(){
		SceneManager.LoadScene (7);
	}
}
