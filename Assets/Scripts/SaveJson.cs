using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveJson : MonoBehaviour
{

    static public string expo;
    static public bool expo2;
    static public int expo3;
    static public string expo4;
    static public int expo5;
    static public int expo6;

    [System.Serializable]
    public class MyClass
    {
       
        
        public string playerName;
        public string speed;
        public int lives;
        public int score;
        public int music;
        

    }
    public   SaveJson.MyClass myObject = new SaveJson.MyClass();
    public void Start()
    {



    }

    public void SavvIt()
    {
        myObject.playerName = PlayerPrefs.GetString("Name");
        myObject.score = Score.CurrentScore;
        myObject.speed = DropD.forwardForce;
        myObject.lives = DropD1.lives;
        myObject.music = Toggles.tog;
        Debug.Log(myObject.playerName);
       
        var json = JsonUtility.ToJson(myObject);
        
        Debug.Log(myObject.score);
        PlayerPrefs.SetString("Save", json);
       
        PlayerPrefs.Save();
        expo2 = false;
    }

    public void LoadIt()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        string json = PlayerPrefs.GetString("Save");
       
        myObject = JsonUtility.FromJson<SaveJson.MyClass>(json);
      

       
        Debug.Log(myObject.playerName);
        Debug.Log(myObject.score);
        
        

        expo = myObject.playerName;
        expo3 = myObject.score;
        expo4 = myObject.speed;
        expo5 = myObject.lives;
        expo6 = myObject.music;
        PlayerPrefs.Save();
        Debug.Log(expo6);
        expo2 = true;
    }
   
    
}
