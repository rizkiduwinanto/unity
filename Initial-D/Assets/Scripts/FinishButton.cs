using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishButton : MonoBehaviour {
	public string trackID;
	public string userID;
	public int totalSec;

	public static DatabaseManager databaseInstance;

	public void backMainMenu() {
		trackID = PlayerPrefs.GetString ("Scene");
		userID = PlayerPrefs.GetString ("userId");

		totalSec = LapTimeManager.BestMinCount * 60 +
		LapTimeManager.BestSecCount;

		Debug.Log (trackID);
		Debug.Log (userID);
		databaseInstance = new DatabaseManager ();
		databaseInstance.insertHighscore (userID, trackID, totalSec);

		SceneManager.LoadScene ("MenuScreen");
	}
}
