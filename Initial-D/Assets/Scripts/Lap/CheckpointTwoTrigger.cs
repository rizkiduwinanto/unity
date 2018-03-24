using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTwoTrigger : MonoBehaviour {

    public GameObject FinishTrig;
    public GameObject CheckpointOneTrig;
    public GameObject CheckpointTwoTrig;
    public GameObject CheckpointThreeTrig;
    public GameObject CheckpointFourTrig;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pemaen")
        {
            FinishTrig.SetActive(false);
            CheckpointOneTrig.SetActive(false);
            CheckpointTwoTrig.SetActive(false);
            CheckpointThreeTrig.SetActive(true);
            CheckpointFourTrig.SetActive(false);
        }
    }
}
