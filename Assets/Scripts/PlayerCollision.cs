using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
public PlayerMovement movement;
AudioSource audioSource;

public AudioClip coinAcquireSound;
public AudioClip collisionSound;




    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "SphericalObstacle")
        {
            float impulse = collisionInfo.impulse.sqrMagnitude;
            if (impulse > 75)
            {
                audioSource.PlayOneShot(collisionSound, 1.0f);
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            } else {
                audioSource.PlayOneShot(collisionSound, impulse / 75);
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
