using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    //EJERCICIO 8.1 / EJERCICIO 8.4
    
    [SerializeField] string nombre;
    [SerializeField] float vida;
    [SerializeField] float experiencia;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarNivel()
    {
        float nivel = CalcularNivel(experiencia);
        Debug.Log("El nivel del personaje es: " + nivel);
    }

    public static float CalcularNivel(float experienciaTotal)
    {
        float nivel;
        nivel = experienciaTotal / 1000;
        return nivel;
    }
}
