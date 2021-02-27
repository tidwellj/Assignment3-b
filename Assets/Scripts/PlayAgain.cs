using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayAgainFrog()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Score.CurrentScore = 0;

    }


}
