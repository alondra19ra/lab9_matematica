using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionConAceleracion : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadInicial = 1f;
    public float aceleracion = 0.5f;

    private float velocidadActual;
    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo != null)
        {
            float step = velocidadActual * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, objetivo.position, step);
            velocidadActual += aceleracion * Time.deltaTime; 
        }
    }
}
