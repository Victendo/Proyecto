using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 5;
    float exp = 15.67f;
    char carac = 'L';
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vidas: " + vidas + " exp = " + exp);

        float resultadoSuma = vidas + exp;
        Debug.Log("La suma de las " + vidas + " vidas y el nivel " + exp + " de exp crea el total de: " + resultadoSuma);

        float resultadoResta = vidas - exp;
        Debug.Log("La resta de las " + vidas + " vidas y el nivel " + exp + " de exp crea el total de: " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
