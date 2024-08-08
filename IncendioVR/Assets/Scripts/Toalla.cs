using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toalla : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
