using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Player"))
        {
            return;
        }
        if(other.gameObject.CompareTag("Collider"))
        {
            return;
        }
        else
        {
            other.gameObject.SetActive(false);
        }
    }
}
