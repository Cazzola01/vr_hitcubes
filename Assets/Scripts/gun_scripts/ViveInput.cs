using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour {

    public SteamVR_Action_Single squeezAction;

    public float triggerValue;

    // Update is called once per frame
    void Update () {
        triggerValue = squeezAction.GetAxis(SteamVR_Input_Sources.Any);

        if (triggerValue > 0.0f)
        {
            FindObjectOfType<Rotate_trigger>().Rotate();
            FindObjectOfType<Laser>().Raycastlaser();
        }
	}
}
