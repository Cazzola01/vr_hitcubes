using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    //public Control_script_obj Control_script_obj;

    public Transform laserpos;

    bool trigger_gone_back = true;

    //public Material red;

    Vector3 hitvector = new Vector3(0, 0, 0);

    public void Raycastlaser()
    {
        float triggerValue = FindObjectOfType<ViveInput>().triggerValue; //Om ändrar, måste vara i functionen

        if (triggerValue == 1 && trigger_gone_back == true) //skjuter
        {
            RaycastHit hit;

            if (Physics.Raycast(laserpos.position, laserpos.forward, out hit))
            {
                //print("lasershot");

                if (hit.collider.gameObject.CompareTag("Cube"))
                {
                    
                    //print("Cube tag hit");
                    //FindObjectOfType<Destroy_cube>().Destroy();
                    //print(hit.collider.gameObject.transform.position);
                    //Control_script_obj.vector[1] = hit.collider.gameObject.transform.position;

                    //FindObjectOfType<RecordScript>().Record(hit.collider.gameObject.transform.position);

                    if (FindObjectOfType<RecordScript>().RecordBool == true)
                    {
                        FindObjectOfType<RecordScript>().Record(hit.collider.gameObject.transform.position);
                    }
                    //
                    else
                    {
                        //if (hit.collider.gameObject.renderer.shared == red)
                        FindObjectOfType<RecordScript>().hitstart = true; //Hit(hit.collider.gameObject.transform.position);
                        //hitvector = hit.collider.gameObject.transform.position;
                    }

                }
            }

            trigger_gone_back = false;
        }

        if (triggerValue < 1 && trigger_gone_back == false) //kollar så man har dragit tillbaka triggern
        {
            trigger_gone_back = true;
        }

    }

}
