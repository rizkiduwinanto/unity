using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManagerAI : MonoBehaviour {

    public static int MinCount;
    public static int SecCount;
    public static float MiliSecCount;

    public static int TotalMinCount;
    public static int TotalSecCount;
    public static float TotalMiliSecCount;
	
	// Update is called once per frame
	void Update () {
        MiliSecCount += Time.deltaTime * 10;

        if (MiliSecCount >= 10)
        {
            MiliSecCount = 0;
            SecCount += 1;
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }
	}
}
