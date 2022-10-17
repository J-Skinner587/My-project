using UnityEngine;

public class ShowUI : MonoBehaviour

{

    public GameObject uiObject;

    void Start()

    {

        uiObject.SetActive(false);

    }

    void OnTriggerEnter(Collider player)

    {

        if (player.gameObject.tag == "Player")

        {

            uiObject.SetActive(true);

        }

    }
}