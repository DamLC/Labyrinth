using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField]
    Transform myTarget;

    [SerializeField]
    SpikeController spikeController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            spikeController.target = myTarget;
        }
    }
}
