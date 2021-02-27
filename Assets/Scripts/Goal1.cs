
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal1 : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
