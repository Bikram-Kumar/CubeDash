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
        bool touchDownLeft = false, touchDownRight = false;
        
        if (Input.touchCount > 0)
        {
            Vector2 latestTouchPosition = Input.GetTouch(Input.touchCount - 1).position;
            touchDownLeft = (latestTouchPosition.x < (Screen.width / 2));
            touchDownRight = (latestTouchPosition.x > (Screen.width / 2));

        }
        moveLeft = (Input.GetKey("a") || Input.GetKey("left") || touchDownLeft);
        moveRight = (Input.GetKey("d") || Input.GetKey("right") || touchDownRight);
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
