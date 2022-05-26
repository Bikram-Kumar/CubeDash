using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
public PlayerMovement movement;
AudioSource audioSource;
public AudioClip coinAcquireSound;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
            audioSource.PlayOneShot(coinAcquireSound, 1.0f);
       } else if (collisionInfo.gameObject.tag == "GameOverTrigger")
       {
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}
