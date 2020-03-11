using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public Puntos puntos;
    public GameObject particulSystem;
    public GameObject[] consumible;
    int numero;

    private void OnCollisionEnter()
    {
        Instantiate(particulSystem, transform.position, Quaternion.identity);

        // Numero Random
        numero = Random.Range(1, 10);
        if (numero == 1 || numero == 2)
        {
            Instantiate(consumible[0], transform.position, Quaternion.identity);
        }else if (numero == 3)
        {
            Instantiate(consumible[1], transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPuntos();
        
    }
}
