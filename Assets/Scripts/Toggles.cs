using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Toggles : MonoBehaviour
{
    public GameObject music;

    public static int tog = 0;
    public  Toggle toggle;
    public  AudioSource myAudio;
    public void Awake()
    {








        if (SaveJson.expo2 == false)
        {



            if (toggle.isOn == true)
            {
                myAudio.enabled = true;
                tog = 0;
            }
            else if (toggle.isOn == false)
            {
                myAudio.enabled = false;
                tog = 1;
                toggle.isOn = false;
            }
        }
        else if(SaveJson.expo6 == 1)
        {

        }
    }


    }
