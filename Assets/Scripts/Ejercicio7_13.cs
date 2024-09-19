using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrimoDivisible(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrimoDivisible(int numero)
    {
        if (numero == 0 || numero ==1)
        {
            Debug.Log(numero + " no es un numero primo");
        }
        for (int i = 2; i <= numero; i++)
        {
            if (numero % 2 == 0)
            {
                Debug.Log(numero + " no es un numero primo");
            }
            else
            {
                Debug.Log(numero + " es un numero primo");
            }
        }
    }
}
