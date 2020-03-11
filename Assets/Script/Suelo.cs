using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vidas vidas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pelota"))
        {
            vidas.PerderVida();
        }
    }
}
