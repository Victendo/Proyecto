using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //EJERCICIO 8.1 / EJERCICIO 8.2 / EJERCICIO 8.3 / EJERCICIO 8.4
    [SerializeField] Personaje mario;
    [SerializeField] Personaje sonic;
    [SerializeField] SistemaDeVida marioVida;
    [SerializeField] SistemaDeVida sonicVida;
    [SerializeField] Arma marioArma;
    [SerializeField] Arma sonicArma;


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
        marioArma.DanhoMinimo = 10;
        marioArma.DanhoMaximo = 20;


        sonic = new Personaje();
        sonic.Nombre = "Sonic the Hedgehog";
        sonic.Vida = 82.5f;
        sonic.Experiencia = 3820;
        sonicVida.VidaInicial = 100.0f;
        sonicVida.VidaActual = 100.0f;
        sonicArma.DanhoMinimo = 8;
        sonicArma.DanhoMaximo = 22;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CuraMario();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            CuraSonic();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DisparoMario();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            DisparoSonic();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RecargaMario();
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            RecargaSonic();
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



    void CuraMario()
    {
        bool ejecucion = false;
        if (ejecucion == false)
        {
            marioVida.CuraPersonaje();
            ejecucion = true;
        }

        if (ejecucion == true)
        {
            Debug.Log("yaEjecutado");
        }
        
    }

    void CuraSonic()
    {
        bool ejecucion = false;
        if (ejecucion == false)
        {
            sonicVida.CuraPersonaje();
            ejecucion = true;
        }

        if (ejecucion == true)
        {
            Debug.Log("yaEjecutado");
        }

    }




    void DisparoMario()
    {
            System.Random aleatorio = new System.Random();
            float disparo = aleatorio.Next(10, 21);
            sonicVida.VidaActual = sonicVida.VidaActual - disparo;
            marioArma.ResultadoUso();
    }

    void DisparoSonic()
    {
        System.Random aleatorio = new System.Random();
        float disparo = aleatorio.Next(8, 23);
        marioVida.VidaActual = marioVida.VidaActual - disparo;
        sonicArma.ResultadoUso();
    }




    void RecargaMario()
    {
        marioArma.ResultadoRecarga();
    }

    void RecargaSonic()
    {
        sonicArma.ResultadoRecarga();
    }
}
