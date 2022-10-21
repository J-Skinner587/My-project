using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab1;

    void OnTriggerEnter(Collider other)
    {   
        if(other.name == "Spawner")
        {
            Prefab1.SetActive(true);
        }
    }
}
