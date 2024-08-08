using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoDesaparece : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Polvo"))
        {
            gameObject.SetActive(false);
        }
    }
}
