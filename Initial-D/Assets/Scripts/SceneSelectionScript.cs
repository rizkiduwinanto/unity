using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelectionScript : MonoBehaviour {

	public void playDownValley() {
		PlayerPrefs.SetString ("Scene", "DownValley");
		SceneManager.LoadScene (3);
	}

	public void playLakeSide(){
		PlayerPrefs.SetString ("Scene", "LakeSide");
		SceneManager.LoadScene (3);
	}

	public void doBack(){
		SceneManager.LoadScene (6);
	}
}