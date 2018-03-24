using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelectionScript : MonoBehaviour {

	public void playGreen() {
		SceneManager.LoadScene (5);
	}

	public void playRed(){
		SceneManager.LoadScene (5);
	}

	public void playBlue(){
		SceneManager.LoadScene (5);
	}
}
