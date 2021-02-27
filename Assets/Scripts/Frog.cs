
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    static public int lives = 0;
    static public int lives2 = 0;
    static public string its = SaveJson.expo4;
    public  AudioSource  audioData;
    static public int staTe = 0;
    // Update is called once per frame
    void Start()
    {
        
        audioData = GetComponent<AudioSource>();
       
        Debug.Log("started");
    }


    void Update()
    {
        Vector2 pos = transform.position;
        //Clamp Movement;
        pos.x = Mathf.Clamp(pos.x, -7f, 7f);
        pos.y = Mathf.Clamp(pos.y, -4, 30f);
        transform.position = pos;


        

        if (SaveJson.expo2 == false)
        {
            if (DropD1.lives == 3)
            {
               
                lives2 = 3;

            }
            if (DropD1.lives == 2)
            {
                
                lives2 = 2;

            }
            if (DropD1.lives == 1)
            {
               
                lives2 = 1;

            }
            

        }
        else if(SaveJson.expo2 == true)
        {
            if (SaveJson.expo5 == 3)
            {
               
                lives2 = 3;

            }
            if (SaveJson.expo5 == 2)
            {
                
                lives2 = 2;

            }
            if (SaveJson.expo5 == 1)
            {
                Debug.Log(DropD1.lives);
                
                lives2 = 1;

            }



        }

    

          if (lives == lives2)
{
    SceneManager.LoadScene("Credits");
    lives = 0;
}


if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            if (!audioData.isPlaying)
                audioData.Play(0);

        }
        

         else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
            if (!audioData.isPlaying)
                audioData.Play(0);
        }
       

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            if (!audioData.isPlaying)
                audioData.Play(0);
        }
       

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        { 
            rb.MovePosition(rb.position + Vector2.down);
        
            if (!audioData.isPlaying)
                audioData.Play(0);
        }
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            lives++;
           
            Debug.Log("We Lost!");
            Score.CurrentScore = 0;
            Score.newscore = 0;
            car.currentspeed = "Easy";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
