using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_9 : MonoBehaviour
{
    int tipo;
    int da�o;
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
            da�o = 350;
            vida = 650;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else if (tipo == 2)
        {
            da�o = 300;
            vida = 550;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else if (tipo == 3)
        {
            da�o = 300;
            vida = 500;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else if (tipo == 4)
        {
            da�o = 310;
            vida = 460;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else if (tipo == 5)
        {
            da�o = 280;
            vida = 490;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else if (tipo == 6)
        {
            da�o = 360;
            vida = 520;
            Debug.Log("Enemigo " + tipo + ". Da�o: " + da�o + ". Vida: " + vida);
        }

        else
        {
            Debug.Log("Tipo desconocido.");
        }
    }
}
