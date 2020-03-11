using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBarra : MonoBehaviour
{
    public float velocidad = 0.4f;

    Vector3  posicionInicial;
    Vector3 escalaInicial;

    Vector3 escalaLarga;

    public ElementoInteractivo botonIzquierdo;
    public ElementoInteractivo botonDerecho;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        escalaInicial = transform.localScale;
        escalaLarga = new Vector3(10f, 5f, 4.650002f);
        posicionInicial = transform.position; 
    }
    public void Reset()
    {
        transform.localScale = escalaInicial;
        transform.position = posicionInicial;
    }
    // Update is called once per frame
    void Update()
    {
        float direccion;
        if(botonIzquierdo.pulsado)
        {
            direccion = -1;
        }else if(botonDerecho.pulsado)
        {
            direccion = 1;
        }else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }
        // Otra forma de escribirlo
        // float direccion = botonIzquierdo.pulsado ? -1 : (botonDerecho.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        // Se elimina linea.
        //float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (direccion * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp( posX, -8f, 8f), transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        if(collision.CompareTag("PoderLargo"))
        {
            //transform.localScale = escalaLarga;
            
            anim.SetTrigger("Largo");
        }
    }
}

