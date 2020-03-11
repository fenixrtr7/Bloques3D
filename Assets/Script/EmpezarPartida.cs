using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
    public  ElementoInteractivo pantalla;
    public ElementoInteractivo pantalla2;

    // Update is called once per frame
    void Update()
    {
        // Inicia partoda con boton disparador
        if(Input.GetButtonDown("Fire1") || pantalla.pulsado || pantalla2.pulsado)
        {
            // Carga puntos y nivel a empezar
            Vidas.vidas = 3;
            Puntos.puntos = 0;
            Debug.Log("Carnagdo portada");
            SceneManager.LoadScene("Nivel01");
        }
    }
}
