using UnityEngine;

public class GearTrigger : MonoBehaviour
{

    public Vector3 GearForce = new Vector3(0f, 30f, 10f);
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(GearForce, ForceMode.VelocityChange);
        }
    }
}
