using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerStop : MonoBehaviour {

    public GameObject CarControl;

    void Start()
    {
		CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = false;
		CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarUserControl> ().enabled = false;
    }
}
