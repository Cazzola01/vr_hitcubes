using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RecordScript : MonoBehaviour {

    public Transform cube;

    public Control_script_obj Script_obj;

    public bool RecordBool = false, Recordreset = false, hitstart = false;

    int r = 0, j = 0;

    float music_time = 0;

    public Material gray, red, blue;
    Renderer rend;

    public float show_time = 1;

    Vector3 hitvector = new Vector3();

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void Update()
    {
        music_time = FindObjectOfType<Music_script>().music_time; //tar tid

        if (Input.GetKey("r")) //startar record
        {
            RecordBool = true;
            print("You are recording");
        }

        if (RecordBool == false)
        {
            if (j <= Script_obj.song_time.Length && Script_obj.song_time[j] != 0)
            {
                Show();  //Standrad startar Show
            }
            
        }

        //Hit(); //starta script

        if (hitstart == true)
        {
            print("hit true");
            Hit(); //starta script
            hitstart = false;
            
        }
        
    }

    public void Record(Vector3 vector) //Startar från Laser script
    {
        if (Recordreset == false)
        {
            print("hey");
            for (int i = 0; i < Script_obj.song_time.Length; i++)
            {
                Script_obj.song_time[i] = 0f;
                Script_obj.vector[i] = new Vector3 (0,0,0);
            }
            Recordreset = true;
        }

            Debug.Log(music_time);
            print(vector);

            Script_obj.song_time[r] = music_time; //tar nuvarande musik
            Script_obj.vector[r] = vector; //tar skjuten positoin

        r++;
    }


    public void Show()
    {
        
            if (music_time > Script_obj.song_time[j] - show_time/2)
            {
            //print(cube.position);
            if (cube.position == Script_obj.vector[j])
                {
                //Debug.Log(cube.position);
                //Debug.Log(music_time);
                StartCoroutine(Showcolor());
            }
            j++;
            }
    }

    public void Takeinhit(Vector3 vector)
    {
        hitvector = vector;
    }

    public void Hit() //Vector3 vector)
    {
        //print(hitvector);
        /*if (hitvector == cube.position && rend.sharedMaterial == red)
        {
            StartCoroutine(Hitcolor());
        }*/
        print(cube.position);
        //print(vector);*/
        /*
        if (vector == Script_obj.vector[j - 1])
        {
            Debug.LogWarning("vector right");
            if (Math.Abs(Script_obj.song_time[j - 1] - music_time) <= show_time / 2)
            {
                Debug.LogWarning("hey");
                if (cube.position == vector)
                {
                    Debug.LogWarning("hey555");
                    StartCoroutine(Hitcolor());
                }
            }
        }*/
    }

    IEnumerator Showcolor()
    {
        rend.sharedMaterial = red;

        yield return new WaitForSeconds(show_time);
            rend.sharedMaterial = gray;

    }

    IEnumerator Hitcolor()
    {
        rend.sharedMaterial = blue;
        yield return new WaitForSeconds(5);
        rend.sharedMaterial = gray;
        print("hit done");
        //hitactive = true;
    }

}