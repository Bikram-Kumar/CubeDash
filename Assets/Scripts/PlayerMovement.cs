using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 200f;
    bool moveLeft;
    bool moveRight;


    void Update()
    {
        moveLeft = Input.GetKey("a");
        moveRight = Input.GetKey("d");
    }

     void FixedUpdate()
     {
      
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);
         
         if (moveLeft)
         {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }

         if (moveRight)
         {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }

         if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


     }
}
