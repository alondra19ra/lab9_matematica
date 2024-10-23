using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUScript : MonoBehaviour
{
    public float velocidadInicial = 15f; 
    public float tiempo = 50f; 

    private float posicionInicial;
    void Start()
    {
        posicionInicial = transform.position.x;
    }

    void Update()
    {
        float tiempoTranscurrido = Time.time;

   
        float nuevaPosicion = posicionInicial + velocidadInicial * tiempoTranscurrido;

        transform.position = new Vector3(nuevaPosicion, transform.position.y, transform.position.z);
    }
}
