using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_trigger : MonoBehaviour {

    public float maxrotation = -30; 

    public void Rotate()
    {
        float triggerValue = FindObjectOfType<ViveInput>().triggerValue; //Om ändrar, måste vara i functionen

        transform.localRotation = Quaternion.Euler(0, 0, 1 * maxrotation * triggerValue);
    }
}
