using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelectionScript : MonoBehaviour {

	public void playDownValley() {
		PlayerPrefs.SetString ("Mode", "DownValley");
		SceneManager.LoadScene (3);
	}

	public void playLakeSide(){
		PlayerPrefs.SetString ("Mode", "LakeSide");
		SceneManager.LoadScene (3);
	}
}
