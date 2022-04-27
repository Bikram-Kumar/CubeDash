using UnityEngine;

public class TriggerSpheres : MonoBehaviour
{
    public float triggerSpeed = 5f;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("SphericalObstacle"))
            {
                Vector3 displacementUnitVec = (transform.position - sphere.transform.position).normalized;
                sphere.GetComponent<Rigidbody>().AddForce(displacementUnitVec * triggerSpeed , ForceMode.VelocityChange);
            }

        }
    }
}

