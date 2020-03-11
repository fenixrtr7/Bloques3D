using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonSalir : MonoBehaviour
{
    public bool salir;

    // Update is called once per frame
    void Update()
    {
        // Activamos escape para salir del nivel y del juego
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("Salimos del juego");
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Portada");
            }
        }
        // Reset
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reset escena donde estamos
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
