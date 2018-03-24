using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatabaseManager {

	public SqliteConnection connection;
	private static string databaseLocation = "URI=file:" + Application.dataPath + "/Database/db_unity.db";

	public DatabaseManager () {
		connection = new SqliteConnection(databaseLocation);
		connection.Open ();
	}

	public void closeConnection() {
		connection.Close();
	}

	public void insertUser(string username, string password) {
		string sql = "INSERT INTO tb_user(username, password) VALUES ('" + username + "','" + password + "')";
		SqliteCommand command = new SqliteCommand (sql, connection);
		command.ExecuteReader ();
	}

	public SqliteDataReader doLogin(string username, string password) {
		string sql = "SELECT * FROM tb_user WHERE username = '" + username + "' AND password = '" + password + "'";
		SqliteCommand command = new SqliteCommand (sql, connection);
		SqliteDataReader reader = command.ExecuteReader ();
		return reader;
	}

	public void insertHighscore(string userId, string trackId, int time) {
		string sql = "INSERT INTO tb_highscore(id_track, id_user, time) VALUES (" + trackId + "," + userId + ",'" + time + "')";
		SqliteCommand command = new SqliteCommand (sql, connection);
		command.ExecuteReader ();
	}

	public SqliteDataReader getHighscore(string trackId) {
		string sql = "SELECT * FROM tb_highscore NATURAL JOIN tb_user WHERE id_track = '" + trackId + "'";
		SqliteCommand command = new SqliteCommand (sql, connection);
		SqliteDataReader reader = command.ExecuteReader ();
		return reader;
	}

	public SqliteDataReader Test() {
		string sql = "SELECT * FROM tb_user WHERE username = 'yesa'";
		SqliteCommand command = new SqliteCommand (sql, connection);
		SqliteDataReader reader = command.ExecuteReader ();
		SqliteDataReader tempReader = reader;
		while (tempReader.Read ()) {
			Debug.Log (reader ["id_user"] + " " + reader ["username"] + " " + reader ["password"]);
		}
		return reader;
	}
}

