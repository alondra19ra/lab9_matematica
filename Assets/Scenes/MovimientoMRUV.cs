using UnityEngine;
using UnityEngine.UI;

public class MovimientoMRUV : MonoBehaviour
{
    public Text textoVelocidad; 
    public Text textoTiempo;   
    public Text textoAceleracion; 
    public Text textoDistancia;   

    public Slider sliderVelocidad; 
    public Slider sliderTiempo;    
    public Slider sliderAceleracion; 

    private float velocidadInicial;
    private float tiempo;
    private float aceleracion;
    private float distancia;

    void Update()
    {
        velocidadInicial = sliderVelocidad.value;
        tiempo = sliderTiempo.value;
        aceleracion = sliderAceleracion.value;

        distancia = (velocidadInicial * tiempo) + (0.5f * aceleracion * Mathf.Pow(tiempo, 2));

        textoVelocidad.text = "V₀: " + velocidadInicial.ToString("F2");
        textoTiempo.text = "t: " + tiempo.ToString("F2");
        textoAceleracion.text = "a: " + aceleracion.ToString("F2");
        textoDistancia.text = "x: " + distancia.ToString("F2");
    }
}
