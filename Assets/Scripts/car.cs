
using UnityEngine;

public class car : MonoBehaviour
{
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public Rigidbody2D rb;
    static public float speed = 1f;
    static public string currentspeed = SaveJson.expo4;
    // Start is called before the first frame update
  void Start()
    {
        if (SaveJson.expo2 == false)
        {
            if (DropD.forwardForce == "Easy")
            {
                minSpeed = 4f;
                maxSpeed = 8f;
            }
            else if (DropD.forwardForce == "Medium")
            {

                minSpeed = 8f;
                maxSpeed = 12f;
            }
            if (DropD.forwardForce == "Difficult")
            {
                Debug.Log("Here");
                minSpeed = 12f;
                maxSpeed = 16F;
            }
        }
        else if (SaveJson.expo2 == true)
        {
            if (currentspeed == "Easy")
            {
                minSpeed = 4f;
                maxSpeed = 8f;
            }
            else if (currentspeed == "Medium")
            {

                minSpeed = 8f;
                maxSpeed = 12f;
            }
            if (currentspeed == "Difficult")
            {
                Debug.Log("Here");
                minSpeed = 12f;
                maxSpeed = 16F;
            }
        }
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
