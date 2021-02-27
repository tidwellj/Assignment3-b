using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class livesnum : MonoBehaviour
{
    public Text livestxt;
    // Start is called before the first frame update
    void Start()
    {
        if (SaveJson.expo2 == false)
        {
            livestxt.text = DropD1.lives.ToString();
        }
        else if (SaveJson.expo2 == true)
        {
            livestxt.text = SaveJson.expo5.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
