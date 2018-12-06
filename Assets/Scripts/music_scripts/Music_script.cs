using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Music_script : MonoBehaviour
{

    private AudioSource music;
    bool MusicHasPlayed = false;
    public float audiostarttime = 10;

    float[] music_time_array = new float[1];

    bool music_written = false;

    int note = 0;

    public float music_time;

    public void Start()
    {
        music = GetComponent<AudioSource>();
        Debug.LogWarning(" Rememer 'music on awake off'");
    }

    // Update is called once per frame
    void Update()
    {
        music_time = music.time; //ger float tid, så kan använda i annan function
        
   
        StartMusic();

        SaveTime();

        WriteTime();

    }

    public void StartMusic()
    {
        //startar musiken
        if ((Time.realtimeSinceStartup >= audiostarttime) && MusicHasPlayed == false)
        {
            //Debug.Log(Time.realtimeSinceStartup);

            music.Play();

            MusicHasPlayed = true;

        }
    }

    public void SaveTime()
    {

        //sparar tid i array
        if (Input.GetKeyDown("q") && music.time > 0)
        {
            //Debug.Log("q pressed: " + music.time);

            music_time_array[note] = music.time;

            Array.Resize(ref music_time_array, music_time_array.Length + 1); //Gör arrayn 1 plats större

            note++;

        }
    }

    public void WriteTime()
    {

        //skriver ut array
        if (Time.realtimeSinceStartup > 10 && music_written == false)
        {

            for (int i = 0; i < music_time_array.Length - 1; i++)
            {
                //Debug.LogWarning("time: " + music_time_array[i]);
            }

            music_written = true;

        }
    }
}


