using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_10 : MonoBehaviour
{
    [SerializeField] int primerNumero = -12;
    [SerializeField] int segundoNumero = 33;
    // Start is called before the first frame update
    void Start()
    {
        BucleTotal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BucleTotal ()
    {
        for (int i = primerNumero; i <= segundoNumero; i++)
        {
            if (i < 0 && i % 2 == 0)
            {
                Debug.Log(i + " es un numero negativo y par");
            }

            else if (i < 0 && i % 2 != 0)
            {
                Debug.Log(i + " es un numero negativo e impar");
            }

            else if (i >= 0 && i % 2 == 0)
            {
                Debug.Log(i + " es un numero positivo y par");
            }

            else 
            {
                Debug.Log(i + " es un numero positivo e impar");
            }
        }
    }
}
