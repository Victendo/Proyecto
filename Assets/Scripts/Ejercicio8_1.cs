using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_1 : MonoBehaviour
{
    private string nombre;
    private int vida;
    private float experiencia;
    private bool final;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public bool Final { get => final; set => final = value; }

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
                Debug.Log("Vida: " + vida);
                Debug.Log("Experiencia: " + experiencia);
                Debug.Log("Nivel: " + CalcularNivel());
                final = true;
        }
        if (final == true)
        {
            Debug.Log("yaEjecutado");
        }
    }
}
