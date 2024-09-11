using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 3;
    float exp = 27.33f;
    // Start is called before the first frame update
    void Start()
    {
        float producto = vidas * exp;
        Debug.Log("El producto de vidas (" + vidas + ") y exp (" + exp + ") es: " + resultadoMultiplicación);


        float cociente = vidas / exp;
        Debug.Log("El cociente de vidas (" + vidas + ") y exp (" + exp + ") es: " + resultadoDivisión);


        float resto = vidas % exp;
        Debug.Log("El resto de vidas (" + vidas + ") y exp (" + exp + ") es: " + resultadoResto);


        int dobleVidas = vidas *= 2;
        Debug.Log("El doble de vidas (" + vidas + ") es: " + dobleVidas);


        float tripleExp = exp *= 3;
        Debug.Log("El triple de vidas (" + vidas + ") es: " + tripleExp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
