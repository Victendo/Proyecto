using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SumarTodosLosNumeros(9, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SumarTodosLosNumeros(int primerNumero, int segundoNumero)
    {
        int suma;
        Debug.Log(primerNumero);
        int nuevoNumero = primerNumero;
        while (primerNumero <= segundoNumero)
        {
            int extra = primerNumero + 1;
            suma = nuevoNumero + extra;
            Debug.Log(suma);
            nuevoNumero = suma;
            primerNumero++;

        }
    }
}
