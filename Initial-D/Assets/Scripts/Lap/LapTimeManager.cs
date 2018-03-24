using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public static int MinCount;
    public static int SecCount;
    public static float MiliSecCount;
    public static string MiliDisplay;

    public static int TotalMinCount;
    public static int TotalSecCount;
    public static float TotalMiliSecCount;

    public static int BestMinCount;
    public static int BestSecCount;
    public static float BestMiliSecCount;

    public GameObject MinBox;
    public GameObject SecBox;
    public GameObject MiliSecBox;
	
    void Start () {
        Time.timeScale = 1f;
    }

	// Update is called once per frame
	void Update () {
        MiliSecCount += Time.deltaTime * 10;
        TotalMiliSecCount += Time.deltaTime * 10;
        MiliDisplay = MiliSecCount.ToString ("F0");
        MiliSecBox.GetComponent<Text>().text = "" + MiliDisplay;

        if (MiliSecCount >= 10)
        {
            MiliSecCount = 0;
            SecCount += 1;
        }

        if (TotalMiliSecCount >= 10)
        {
            TotalMiliSecCount = 0;
            TotalSecCount += 1;
        }

        if (SecCount <= 9)
        {
            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        } else
        {
            SecBox.GetComponent<Text>().text = "" + SecCount + ".";
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if (TotalSecCount >= 60)
        {
            TotalSecCount = 0;
            TotalMinCount += 1;
        }

        if (MinCount <= 9)
        {
            MinBox.GetComponent<Text>().text = "0" + MinCount + ":";
        } else
        {
            MinBox.GetComponent<Text>().text = "" + MinCount + ":";
        }
	}
}
