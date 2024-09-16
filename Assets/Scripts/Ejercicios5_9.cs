using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_9 : MonoBehaviour
{
    int tipo;
    int daño;
    int vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarEnemigo ()
    {
        if (tipo == 1)
        {
            daño = 350;
            vida = 650;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else if (tipo == 2)
        {
            daño = 300;
            vida = 550;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else if (tipo == 3)
        {
            daño = 300;
            vida = 500;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else if (tipo == 4)
        {
            daño = 310;
            vida = 460;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else if (tipo == 5)
        {
            daño = 280;
            vida = 490;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else if (tipo == 6)
        {
            daño = 360;
            vida = 520;
            Debug.Log("Enemigo " + tipo + ". Daño: " + daño + ". Vida: " + vida);
        }

        else
        {
            Debug.Log("Tipo desconocido.");
        }
    }
}
