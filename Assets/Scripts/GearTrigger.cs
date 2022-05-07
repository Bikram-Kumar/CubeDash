using UnityEngine;

public class GearTrigger : MonoBehaviour
{

    public Vector3 GearForce = new Vector3(0f, 30f, 10f);
    public float GearSpeed = 5.0f;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(GearForce, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            collision.collider.gameObject.GetComponent<Rigidbody>().AddForce((transform.forward * GearSpeed), ForceMode.VelocityChange);
        }
    }
}
