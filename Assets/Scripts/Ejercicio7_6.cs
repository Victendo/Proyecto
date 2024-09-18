using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numeroWhile = 84;
    [SerializeField] int numFor = 27;
    // Start is called before the first frame update
    void Start()
    {
        BucleNumeralWhile(-84);
        BucleNumeralFor();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BucleNumeralWhile(int negWhile)
    {
        while (numeroWhile >= negWhile)
        {
            Debug.Log(numeroWhile);
            numeroWhile--;
        }
    }

    void BucleNumeralFor()
    {
        for (int i = numFor; i >= -numFor; i--)
        {
            Debug.Log(i);
        }
    }
}
