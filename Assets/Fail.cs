using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fail : MonoBehaviour
{
    public GameObject UI;

    private void Start()
    {
        UI.SetActive(false);    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
