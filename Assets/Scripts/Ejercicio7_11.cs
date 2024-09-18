using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    int multiplicador = 1;
    int multiplicado = 7;
    // Start is called before the first frame update
    void Start()
    {
        TabladeMultiplicar();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void TabladeMultiplicar()
    {
        Debug.Log("TABLA DE MULTIPLICAR DEL 7");
        for (int i = multiplicado; multiplicado <= 70; multiplicado++)
        {
            for (int j = multiplicador; multiplicador <= 10; multiplicador++)
            {
                Debug.Log(multiplicado + " * " + multiplicador + " = " + multiplicado * multiplicador);
            }
        }
    }
}

