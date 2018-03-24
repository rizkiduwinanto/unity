using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarControllerStop : MonoBehaviour {

    public GameObject AICarControl;

    void Start()
    {
        AICarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = false;
		AICarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl> ().enabled = false;
    }
}
