using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Input_test : MonoBehaviour
{

    public float triggerValue;

    public SteamVR_Action_Single squeezAction;
        

    // Update is called once per frame
    void Update()
    {
        triggerValue = squeezAction.GetAxis(SteamVR_Input_Sources.Any);

        FindObjectOfType<Rotate_test>().Endfunction();
    }
}
