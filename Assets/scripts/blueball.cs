using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("red"))
        {
            Destroy(other.gameObject);
        }
    }

}
