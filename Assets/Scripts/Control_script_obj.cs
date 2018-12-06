using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptobject", menuName = "Scriptobject")]
public class Control_script_obj : ScriptableObject
{
    public float[] song_time = new float[4];

    public Vector3[] vector = new Vector3[4];
}

