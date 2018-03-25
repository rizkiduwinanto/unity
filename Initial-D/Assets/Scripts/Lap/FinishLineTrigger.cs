using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineTrigger : MonoBehaviour {

    public GameObject FinishTrig;
    public GameObject CheckpointOneTrig;
    public GameObject CheckpointTwoTrig;
    public GameObject CheckpointThreeTrig;
    public GameObject CheckpointFourTrig;

    public GameObject BestMinBox;
    public GameObject BestSecBox;
    public GameObject BestMiliSecBox;

    public GameObject LapDisplay;

    public GameObject TimerPanel;
    public GameObject LapPanel;
    public GameObject Minimap;
    public GameObject FinishPanel;

    public GameObject TotalMinBox;
    public GameObject TotalSecBox;
    public GameObject TotalMiliSecBox;

    public GameObject PositionBox;

    public GameObject StopCarControl;
    public int LapCount;
    public int maxLap;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pemaen")
        {
            LapCount += 1;

            if (LapCount == 2)
            {
                LapTimeManager.BestMinCount = LapTimeManager.MinCount;
                LapTimeManager.BestSecCount = LapTimeManager.SecCount;
                LapTimeManager.BestMiliSecCount = LapTimeManager.MiliSecCount;
            }
            else
            {
                if (LapTimeManager.MinCount <= LapTimeManager.BestMinCount)
                {
                    LapTimeManager.BestMinCount = LapTimeManager.MinCount;
                    if (LapTimeManager.SecCount <= LapTimeManager.BestSecCount)
                    {
                        LapTimeManager.BestSecCount = LapTimeManager.SecCount;
                        if (LapTimeManager.MiliSecCount <= LapTimeManager.BestMiliSecCount)
                        {
                            LapTimeManager.BestMiliSecCount = LapTimeManager.MiliSecCount;
                        }
                    }
                }
            } 

            if (LapTimeManager.BestMinCount <= 9)
            {
                BestMinBox.GetComponent<Text>().text = "0" + LapTimeManager.BestMinCount + ":";
            }
            else
            {
                BestMinBox.GetComponent<Text>().text = "" + LapTimeManager.BestMinCount + ":";
            }

            if (LapTimeManager.BestSecCount <= 9)
            {
                BestSecBox.GetComponent<Text>().text = "0" + LapTimeManager.BestSecCount + ".";
            }
            else
            {
                BestSecBox.GetComponent<Text>().text = "" + LapTimeManager.BestSecCount + ".";
            }

            BestMiliSecBox.GetComponent<Text>().text = "" + LapTimeManager.BestMiliSecCount;

            LapTimeManager.MinCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MiliSecCount = 0;

            LapDisplay.GetComponent<Text>().text = "" + LapCount;

            if (LapCount > maxLap)
            {
                TimerPanel.SetActive(false);
                LapPanel.SetActive(false);
                Minimap.SetActive(false);

                if (LapTimeManager.TotalMinCount <= 9)
                {
                    TotalMinBox.GetComponent<Text>().text = "0" + LapTimeManager.TotalMinCount + ":";
                }
                else
                {
                    TotalMinBox.GetComponent<Text>().text = "" + LapTimeManager.TotalMinCount + ":";
                }

                if (LapTimeManager.TotalSecCount <= 9)
                {
                    TotalSecBox.GetComponent<Text>().text = "0" + LapTimeManager.TotalSecCount + ".";
                }
                else
                {
                    TotalSecBox.GetComponent<Text>().text = "" + LapTimeManager.TotalSecCount + ".";
                }

                TotalMiliSecBox.GetComponent<Text>().text = "" + LapTimeManager.TotalMiliSecCount;

                if (FinishLineTriggerAI.isFinish) {
                    PositionBox.GetComponent<Text>().text = "" + 2;
                } else {
                    PositionBox.GetComponent<Text>().text = "" + 1;
                }

                FinishPanel.SetActive(true);
                StopCarControl.SetActive(true);
            }

            FinishTrig.SetActive(false);
            CheckpointOneTrig.SetActive(true);
            CheckpointTwoTrig.SetActive(false);
            CheckpointThreeTrig.SetActive(false);
            CheckpointFourTrig.SetActive(false);
        }
    }
}
