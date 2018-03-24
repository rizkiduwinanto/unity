using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighscoreScript : MonoBehaviour {

	public Text track1number1;
	public Text track1number2;
	public Text track1number3;
	public Text track1number4;
	public Text track1number5;
	public Text track1name1;
	public Text track1name2;
	public Text track1name3;
	public Text track1name4;
	public Text track1name5;
	public Text track1time1;
	public Text track1time2;
	public Text track1time3;
	public Text track1time4;
	public Text track1time5;
	public Text track2number1;
	public Text track2number2;
	public Text track2number3;
	public Text track2number4;
	public Text track2number5;
	public Text track2name1;
	public Text track2name2;
	public Text track2name3;
	public Text track2name4;
	public Text track2name5;
	public Text track2time1;
	public Text track2time2;
	public Text track2time3;
	public Text track2time4;
	public Text track2time5;
	public Text textButtonTrack1;
	public Text textButtonTrack2;
	public DatabaseManager databaseManager;
	public List<Record> listRecord;
	public List<Text> listText;

	void Start() {
		string sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName.Equals ("HighscoreScreen")) {
			populateListText ();
			getHighscore ("1");
		}
	}

	public void GoToMainMenu() {
		SceneManager.LoadScene ("MenuScreen");
	}

	public void getHighscore(string trackId) {
		listRecord = new List<Record> ();
		databaseManager = new DatabaseManager ();
		SqliteDataReader reader = databaseManager.getHighscore (trackId);
		while (reader.Read ()) {
			string username = (string) reader ["username"];
			string time = (string) reader ["time"];
			Record record = new Record (username, int.Parse(time));
			listRecord.Add (record);
		}
		databaseManager.closeConnection ();
		List<Record> sortedListRecord = sortListRecord (listRecord);
		renderListRecord (trackId, sortedListRecord);
	}

	public void ShowTrack1() {
		getHighscore ("1");
		textButtonTrack1.fontSize = 35;
		textButtonTrack2.fontSize = 25;
	}

	public void ShowTrack2() {
		getHighscore ("2");
		textButtonTrack1.fontSize = 25;
		textButtonTrack2.fontSize = 35;
	}

	public void renderListRecord(string trackId, List<Record> tempListRecord) {
		int startingIndex = trackId.Equals ("1") ? 0 : 15;
		int endingIndex = trackId.Equals ("1") ? 14 : 29;

		List<Record> listRecord = new List<Record> ();
		for (int i = 0; i < tempListRecord.Count; i++) {
			if (i < 5) {
				listRecord.Add (tempListRecord [i]);
			}
		}

		for (int i = startingIndex, j = 0; i < endingIndex; i = i + 3, j++) {
			if (j < listRecord.Count) {
				Record record = listRecord [j];
				listText [i].enabled = true;
				listText [i + 1].enabled = true;
				listText [i + 2].enabled = true;
				listText [i + 1].text = record.username;
				listText [i + 2].text = record.timeInMiliseconds.ToString ();
			} else {
				listText [i].enabled = false;
				listText [i + 1].enabled = false;
				listText [i + 2].enabled = false;
			}
		}
	}

	public List<Record> sortListRecord(List<Record> listRecord) {
		List<Record> sortedListRecord = new List<Record> ();
		while (listRecord.Count > 0) {
			Record maxRecord = getMaxRecord (listRecord);
			sortedListRecord.Add (maxRecord);
			listRecord.Remove (maxRecord);
		}
		return sortedListRecord;
	}

	public Record getMaxRecord(List<Record> listRecord) {
		Record record = listRecord [0];
		for (int i = 1; i < listRecord.Count; i++) {
			Record tempRecord = listRecord [i];
			if (tempRecord.timeInMiliseconds < record.timeInMiliseconds) {
				record = tempRecord;
			}
		}
		return record;
	}

	public void populateListText() {
		listText = new List<Text> ();  
		listText.Add (track1number1); listText.Add (track1name1); listText.Add (track1time1); 
		listText.Add (track1number2); listText.Add (track1name2); listText.Add (track1time2);
		listText.Add (track1number3); listText.Add (track1name3); listText.Add (track1time3);
		listText.Add (track1number4); listText.Add (track1name4); listText.Add (track1time4);
		listText.Add (track1number5); listText.Add (track1name5); listText.Add (track1time5);
	
		listText.Add (track2number1); listText.Add (track2name1); listText.Add (track2time1);
		listText.Add (track2number2); listText.Add (track2name2); listText.Add (track2time2);
		listText.Add (track2number3); listText.Add (track2name3); listText.Add (track2time3);
		listText.Add (track2number4); listText.Add (track2name4); listText.Add (track2time4);
		listText.Add (track2number5); listText.Add (track2name5); listText.Add (track2time5);
	}

}

public class Record {

	public string username;
	public int timeInMiliseconds;

	public Record(string username, int timeInMiliseconds) {
		this.username = username;
		this.timeInMiliseconds = timeInMiliseconds;
	}
}
