using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Deactivation : MonoBehaviour
{
    private void Deactivate(GameObject obj)
    {
        obj.SetActive(false);
    }
}
