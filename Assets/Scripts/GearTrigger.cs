using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 50f, 0f), ForceMode.VelocityChange);
        }
    }
}
