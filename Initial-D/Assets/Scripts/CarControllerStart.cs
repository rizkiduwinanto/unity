using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerStart : MonoBehaviour {

    public GameObject CarControl;
    public GameObject AICarControl;

    // Use this for initialization
	void Start () {
        CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        AICarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
	}
	
}
