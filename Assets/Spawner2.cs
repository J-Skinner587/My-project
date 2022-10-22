using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Prefab2;

  void OnTriggerEnter(Collider other)
    {
        if (other.name == "Spawner")
        {
            Prefab2.SetActive(true);
        }
    }
}

