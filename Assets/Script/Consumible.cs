using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Suelo"))
        {
            Destroy(gameObject);
        }
    }
    public void Reset()
    {
        Destroy(gameObject);
    }
}
