using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_1 : MonoBehaviour
{
    [SerializeField] private string nombre;
    [SerializeField] private int vidaInicial;
    private int vidaActual;
    [SerializeField] private float experiencia;
    [SerializeField]private bool final;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public bool Final { get => final; set => final = value; }
    public int VidaInicial { get => vidaInicial; set => vidaInicial = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel()
    {
        float nivel = experiencia / 1000;
        return nivel;
    }

    public void PrepararPersonaje()
    {
        if (Input.GetKeyDown(KeyCode.Space) && final == false)
        {
             Debug.Log("Nombre: " + nombre);
                Debug.Log("Vida: " + vidaInicial);
                Debug.Log("Experiencia: " + experiencia);
                Debug.Log("Nivel: " + CalcularNivel());
                final = true;
        }
        if (final == true)
        {
            Debug.Log("yaEjecutado");
        }
    }

    public void SistemaDeVida()
    {
        float cura = RecibirCura();
        float da�o = RecibirDa�o();
    }
    public float RecibirCura()
    {
        vidaActual = vidaInicial + 8;
        vidaInicial = vidaActual;
        if (vidaActual >= 0)
        {
            return vidaActual;
        }
        else
        {
            vidaActual = -1;
            return vidaActual;
        }
        
    }

    public float RecibirDa�o()
    {
        vidaActual = vidaInicial - 5;
        vidaInicial = vidaActual;
        if (vidaActual == 0)
        {
            return vidaActual;
        }
        else if (vidaActual < 0)
        {
            vidaActual = -1;
            return vidaActual;
        }

        else
        {
            return vidaActual;
        }

    }
}
