using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public SiguienteNivel siguienteNivel;
    public Pelota pelota;
    public MovimientoBarra barra;
    public Transform contenedorBloques;
    public AudioSource audioPunto;
    public SonidosFinPartida sonidosFinPartida;
    // Inicializa los puntos y hace el conteo
    void Start()
    {
        ActualizarTextoPuntos();
    }
    void ActualizarTextoPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }
    // Update is called once per frame
    public void GanarPuntos()
    {
        puntos++;
        audioPunto.Play();
        ActualizarTextoPuntos();
        if (contenedorBloques.childCount <= 0)
        {
            sonidosFinPartida.NivelCompletado();
            pelota.DetenerMovimiento();
            barra.enabled = false;
            if (siguienteNivel.EsUltimoNivel())
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }
            siguienteNivel.ActivarCarga();
        }
    }
}
