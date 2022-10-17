using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chaser : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }
    }
}
