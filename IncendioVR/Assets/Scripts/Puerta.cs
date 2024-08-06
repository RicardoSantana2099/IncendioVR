using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnimator.SetTrigger("OpenDoor");
        }
    }
}
