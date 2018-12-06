using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_cube : MonoBehaviour {

    public Transform cubepos; //for respawn
    public Vector3 offset = new Vector3 (0f,5f,0f);
    public Vector3 max = new Vector3(0f, 10f, 0f);


    // Update is called once per frame
    public void Destroy () {
        Debug.Log("Destroy");
        //Destroy(gameObject);
        Instantiate(gameObject, cubepos.position + offset, Quaternion.identity); //for respawn

    }

    private void Update()
    {
        /*
        if (cubepos.position.y > max.y)
        {
            Destroy(gameObject);
        }*/
    }

}
