using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ejercicio8_1 personaje;
    [SerializeField] Ejercicio8_1 personaje2;
    // Start is called before the first frame update
    void Start()
    {
        personaje = new Ejercicio8_1();
        personaje.Nombre = "Mario";
        personaje.Vida = 69;
        personaje.Experiencia = 3600.0f;
        personaje.Final = false;
        personaje.PrepararPersonaje();

        personaje2 = new Ejercicio8_1();
        personaje2.Nombre = "Sonic";
        personaje2.Vida = 83;
        personaje2.Experiencia = 2743.7f;
        personaje2.Final = false;
        personaje2.PrepararPersonaje();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
