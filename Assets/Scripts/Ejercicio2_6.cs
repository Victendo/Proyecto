using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vidas = 4;
    int monedas = 60;
    int tiempojugado = 48;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El jugador tiene " + vidas + " vidas, " + monedas + " monedas y " + tiempojugado + " minutos jugados.");

        float mediaNumeros = (vidas + monedas + tiempojugado) / 3;

        Debug.Log("La media de todos los datos es: " + mediaNumeros);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
