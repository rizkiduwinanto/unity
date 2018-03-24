using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

	public Slider slider;

	public void PlayGame() {
		SceneManager.LoadScene (4);
	}

	public void GoToOptions() {
		
	}

	public void GoToHighscore() {
		SceneManager.LoadScene ("HighscoreScreen");
	}

	public void QuitGame() {
		PlayerPrefs.DeleteAll ();
		Application.Quit ();
	}

	public void UpdateVolumeValue() {
		slider.value = PlayerPrefs.GetFloat ("volume");
	}

	public void SaveVolumeValue() {
		PlayerPrefs.SetFloat ("volume", slider.value);
	}

}
