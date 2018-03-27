using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net;

public class DatabaseManager {
	
	public DatabaseManager () {
		
	}

	public JSONObject insertUser(string username, string password) {
		WebClient client = new WebClient ();
		string result = client.DownloadString(string.Format("http://inspirasidesa.org/server.php?function=insertUser&username=" + username + "&password=" + password));
		JSONObject json = new JSONObject (result);
		return json;
	}

	public JSONObject doLogin(string username, string password) {
		WebClient client = new WebClient ();
		string result = client.DownloadString(string.Format("http://inspirasidesa.org/server.php?function=doLogin&username=" + username + "&password=" + password));
		JSONObject json = new JSONObject (result);
		return json;
	}

	public JSONObject insertHighscore(string userId, string trackId, int time) {
		WebClient client = new WebClient ();
		string result = client.DownloadString(string.Format("http://inspirasidesa.org/server.php?function=insertHighscore&userId=" + userId + "&trackId=" + trackId + "&time=" + time));
		JSONObject json = new JSONObject (result);
		return json;
	}

	public JSONObject getHighscore(string trackId) {
		WebClient client = new WebClient ();
		string result = client.DownloadString(string.Format("http://inspirasidesa.org/server.php?function=getHighscore&trackId=" + trackId));
		JSONObject json = new JSONObject (result);
		return json;
	}
}

