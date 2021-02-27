using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintName : MonoBehaviour
{
    // Start is called before the first frame update

    public Text t1;

    // Start is called before the first frame update

   

    void Update()
    {
        if(SaveJson.expo2 == true)
        {
            t1.text = SaveJson.expo;
        }
        else
        { 
        t1.text = PlayerPrefs.GetString("Name");
      }
    }
}
