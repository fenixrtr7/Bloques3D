using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pelota : MonoBehaviour
{
    public ElementoInteractivo pantalla;

    public float velocidad = 800f;
    Rigidbody rbd;
    bool enJuego;

    Vector3 posicionInicial;
    Vector3 escalaInicial;

    public Transform barra;
    AudioSource audioPelota;
    public Slider slider;

    private void Awake()
    {
        rbd = GetComponent<Rigidbody>();
        audioPelota = GetComponent<AudioSource>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        // Guarda posiscion inicial de la pelota
        posicionInicial = transform.position;
        escalaInicial = new Vector3(1, 1, 1);
    }
    // Metodo para reset
    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }
    // Deteniene el movimiento
    public void DetenerMovimiento()
    {
        rbd.isKinematic = true;
        rbd.velocity = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        /*bool cli = false;
        if(pantalla.pulsado)
        {
            cli = true;
        }
        else
        {
            cli = false;
        }*/
        // Inicia el movimiento de la pelota
        if(!enJuego && (Input.GetButtonDown("Fire1") || pantalla.pulsado))
        {
            float valor = slider.value;
            enJuego = true;
            transform.SetParent(null);
            rbd.isKinematic = false;
            rbd.AddForce(new Vector3 (velocidad * valor, velocidad , velocidad));
            transform.localScale = escalaInicial;
        }
        
    }
    private void OnCollisionEnter(Collision otro)
    {
        // Si "no" hay una colision con bloque suena pelota
        if(!otro.gameObject.CompareTag("Bloque"))
        {
            audioPelota.Play();
        }
        
        
    }
}
