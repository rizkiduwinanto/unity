using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModeChoice : MonoBehaviour {
	public GameObject redCar;
	public GameObject blueCar;
	public GameObject greenCar;
	public GameObject aiCar;
	public int carColor;

	void Start() {
		carColor = CarSelectionScript.color;
		if (carColor == 1) {
			redCar.SetActive(true);
		} 
		if (carColor == 2) {
			blueCar.SetActive(true);
		}
		if (carColor == 3) {
			greenCar.SetActive(true);
		}
		string aiChoice = PlayerPrefs.GetString("Mode", "Singleplayer");
		if (aiChoice == "Multiplayer") {
			aiCar.SetActive (true);
		}
	}
}
