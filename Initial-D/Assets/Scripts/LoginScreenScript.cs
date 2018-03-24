using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScreenScript : MonoBehaviour {

	public InputField mInputUsername;
	public InputField mInputPassword;
	private string username;
	private string password;
	private DatabaseManager databaseManager;

	public void doRegister() {
		username = mInputUsername.text;
		password = mInputPassword.text;
		if (username.Equals ("") || password.Equals ("")) {
			Debug.Log ("Username and password cannot be empty");
			return;
		}

		databaseManager = new DatabaseManager ();
		SqliteDataReader reader = databaseManager.doLogin (username, password);
		if (isUserExist (reader)) {
			Debug.Log ("User already exist");
			return;
		}

		databaseManager.insertUser (username, password);
		Debug.Log ("Registration successful");
	}

	public void doLogin() {
		username = mInputUsername.text;
		password = mInputPassword.text;
		if (username.Equals ("") || password.Equals ("")) {
			Debug.Log ("Username and password cannot be empty");
			return;
		}
			
		databaseManager = new DatabaseManager ();
		SqliteDataReader reader = databaseManager.doLogin (username, password);
		if (!isUserExist (reader)) {
			Debug.Log ("User does not exist");
			return;
		}

		string userId = reader ["id_user"].ToString ();
		PlayerPrefs.SetString ("userId", userId);
		PlayerPrefs.SetFloat ("volume", 50);
		SceneManager.LoadScene ("MenuScreen");
	}

	private bool isUserExist(SqliteDataReader reader) {
		int count = 0;
		while (reader.Read ()) {
			count = count + 1;
		}
		return count > 0;
	}
}
