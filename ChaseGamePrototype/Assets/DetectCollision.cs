using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Enemy")
        {
            other.gameObject.GetComponent<AIMovement>().shrink = true;
        }
    }
}
