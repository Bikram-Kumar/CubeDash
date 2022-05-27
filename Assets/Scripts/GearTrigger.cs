using UnityEngine;

public class GearTrigger : MonoBehaviour
{

    public Vector3 GearForce = new Vector3(0f, 30f, 10f);
    public float GearSpeed = 5.0f;

    bool Accelerated = false;

    public AudioClip airSweepSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }



    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            audioSource.PlayOneShot(airSweepSound, 1.0f);
            collider.gameObject.GetComponent<Rigidbody>().AddForce(GearForce, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.name == "Player" && !Accelerated)
        {
            audioSource.PlayOneShot(airSweepSound, 1.0f);
            collision.collider.gameObject.GetComponent<Rigidbody>().AddForce((transform.forward * GearSpeed) + new Vector3(0,2,0), ForceMode.VelocityChange);
            Accelerated = true;
        }
    }

    
}
