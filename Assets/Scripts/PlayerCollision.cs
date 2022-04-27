using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "SphericalObstacle")
        {
            if (collisionInfo.impulse.sqrMagnitude > 75)
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            
        }

    }

    void OnTriggerEnter(Collider collisionInfo)
   {
       if (collisionInfo.gameObject.tag == "Coin")
       {
            Destroy(collisionInfo.gameObject);
            FindObjectOfType<GameManager>().IncreaseCoinCount();

       }
   }
}
