using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_cubes_script : MonoBehaviour {

    public GameObject cube;
    float depth = 5f;
    float offset_height = 0.5f;
    float offset_width = -2f;

    // Use this for initialization
    void Start () {

        for (int v = 0; v < 5; v++)
        {
            for (int h = 0; h < 5; h++)
            {
                Instantiate(cube, new Vector3(h + offset_width, v + offset_height, depth), Quaternion.identity); //for respawn
            }
        }
    }
}
