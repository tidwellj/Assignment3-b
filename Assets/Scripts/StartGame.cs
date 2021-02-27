using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartThis()
    {
        PlayerPrefs.SetString("Name", GetName.userIDs);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
