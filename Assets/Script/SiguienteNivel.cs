using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string nivelCarga;
    public float retraso;
    [ContextMenu("Activar Carga")]
    // Invoca nivel a cargar con tiempo x de retraso
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }
    // Metodo para cargar nivel
    void CargarNivel()
    {
        if(!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(nivelCarga);
    }
    public bool EsUltimoNivel()
    {
        return nivelCarga == "Portada";
        /* Es lo mismo 
        if (nivelCarga == "Portada")
        {
            return true;
        }else
        {
            return false;
        }
        */
    }
}
