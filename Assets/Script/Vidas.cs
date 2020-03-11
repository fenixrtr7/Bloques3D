using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 10;
    public Text textoVidas;
    public Pelota pelota;
    public MovimientoBarra barra;
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;
    public AudioSource audioPerdidaVida;
    public SonidosFinPartida sonidosFinPartida;
    Consumible consumible;

    // Start is called before the first frame update
    void Start()
    {
        TextoVida();
    }
    void TextoVida()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }
    
    public void PerderVida()
    {
        Vidas.vidas--;
        audioPerdidaVida.Play();
            TextoVida();
        
        for (int i = 1; i <= 10; i++)
        {
            consumible = FindObjectOfType<Consumible>();
            if (consumible != null)
            {
                consumible.Reset();
            }else //if(consumible == null)
            {
                break;
            }
        }
            barra.Reset();
            pelota.Reset();
        if (vidas == 0)
        {
            sonidosFinPartida.GameOver();
            gameOver.SetActive(true);
            barra.enabled = false;
            pelota.enabled = false;
            siguienteNivel.nivelCarga = "Portada";
            siguienteNivel.ActivarCarga();
        }
    }
}
