using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje mario;
    [SerializeField] Personaje sonic;
    [SerializeField] SistemaDeVida marioVida;
    [SerializeField] SistemaDeVida sonicVida;
    
    // Start is called before the first frame update
    void Start()
    {
        mario = new Personaje();
        mario.Nombre = "Mario Bros";
        mario.Vida = 69.9f;
        mario.Experiencia = 2900;
        marioVida = new SistemaDeVida();
        marioVida.VidaInicial = 100.0f;
        marioVida.VidaActual = 100.0f;

        sonic = new Personaje();
        sonic.Nombre = "Sonic the Hedgehog";
        sonic.Vida = 82.5f;
        sonic.Experiencia = 3820;
        sonicVida.VidaInicial = 100.0f;
        sonicVida.VidaActual = 100.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
        }
    }

    void PrepararPersonajes()
    {
        bool ejecucion = false;
        if (ejecucion == false)
        {
            Debug.Log("Nombre Primer Personaje: " + mario.Nombre);
            Debug.Log("Vida Primer Personaje: " + mario.Vida);
            Debug.Log("Experiencia Primer Personaje: " + mario.Experiencia);
            mario.MostrarNivel();

            Debug.Log("Nombre Segundo Personaje: " + sonic.Nombre);
            Debug.Log("Vida Segundo Personaje: " + sonic.Vida);
            Debug.Log("Experiencia Segundo Personaje: " + sonic.Experiencia);
            sonic.MostrarNivel();
            ejecucion = true;
        }
        if (ejecucion == true)
        {
            Debug.Log("yaEjecutado");
        }
    }
}
