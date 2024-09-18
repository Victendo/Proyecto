using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeroWhile = 69;
    [SerializeField] int numeroFor = 33;
    // Start is called before the first frame update
    void Start()
    {
        BucleNumeralWhile(1);
        BucleNumeralFor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BucleNumeralWhile(int numeroInicial)
    {
        while (numeroInicial <= numeroWhile)
        {
            Debug.Log(numeroInicial);
            numeroInicial++;
        }
    }

    void BucleNumeralFor()
    {
        for (int i = 1; i <= numeroFor; i++)
        {
            Debug.Log(i);
        }
    }
}
