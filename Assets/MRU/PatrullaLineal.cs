using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaLineal : MonoBehaviour
{
    public Transform[] puntos;
    public float tiempoDeLlegada = 3f;
    private int puntoActual = 0;

    void Update()
    {
        if (puntos.Length == 0) return;

        Vector3 destino = puntos[puntoActual].position;
        transform.position = Vector3.MoveTowards(transform.position, destino, Time.deltaTime * (Vector3.Distance(transform.position, destino) / tiempoDeLlegada));

        if (Vector3.Distance(transform.position, destino) < 0.1f)
        {
            puntoActual = (puntoActual + 1) % puntos.Length; 
        }

    }
}
