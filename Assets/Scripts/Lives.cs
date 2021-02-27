using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public Text life;

    void Start()
    {
    }

    void Update()
    {
        
           
        

        switch (Frog.lives)
         {
             case 0:
                 life.text = "2";
                 break;
             case 1:
                 life.text = "1";
                 break;
             case 2:
                 life.text = "0";
                 break;
             default:
                 break;
         }


    }

    
}
