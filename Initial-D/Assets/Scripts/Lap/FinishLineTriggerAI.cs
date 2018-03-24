using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineTriggerAI : MonoBehaviour {

    public GameObject FinishTrig;
    public GameObject CheckpointOneTrig;
    public GameObject CheckpointTwoTrig;
    public GameObject CheckpointThreeTrig;
    public GameObject CheckpointFourTrig;

    public GameObject StopAICarControl;

    public static bool isFinish = false;
    public int LapCount;
    public int maxLap;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ai")
        {
            LapCount += 1;

            if (LapCount <= maxLap)
            {
                FinishTrig.SetActive(false);
                CheckpointOneTrig.SetActive(true);
                CheckpointTwoTrig.SetActive(false);
                CheckpointThreeTrig.SetActive(false);
                CheckpointFourTrig.SetActive(false);
            } else
            {
                isFinish = true;
                LapTimeManagerAI.TotalMinCount = LapTimeManagerAI.MinCount;
                LapTimeManagerAI.TotalSecCount = LapTimeManagerAI.SecCount;
                LapTimeManagerAI.TotalMiliSecCount = LapTimeManagerAI.MiliSecCount;
                StopAICarControl.SetActive(true);
            }
            
        }
    }
}
