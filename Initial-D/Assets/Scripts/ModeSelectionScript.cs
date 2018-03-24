using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModeSelectionScript : MonoBehaviour {

	public void playVersus() {
		PlayerPrefs.SetString ("Mode", "Multiplayer");
		SceneManager.LoadScene (5);
	}

	public void playTimeAttack(){
		PlayerPrefs.SetString ("Mode", "Singleplayer");
		SceneManager.LoadScene (5);
	}
}
