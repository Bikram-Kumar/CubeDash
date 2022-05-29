using UnityEngine;

public class TriggerSpheres : MonoBehaviour
{
    public float triggerSpeed = 5f;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Player")
        {
            Transform sphericalObstacles = transform.parent.Find("SphericalObstacles").transform;

            for (int i = 0; i < sphericalObstacles.childCount; i++) 
            {
                GameObject sphere = sphericalObstacles.GetChild(i).gameObject;
                Vector3 displacementUnitVec = (transform.position - sphere.transform.position).normalized;
                sphere.GetComponent<Rigidbody>().AddForce(displacementUnitVec * triggerSpeed , ForceMode.VelocityChange);
            }

        }
    }
}

