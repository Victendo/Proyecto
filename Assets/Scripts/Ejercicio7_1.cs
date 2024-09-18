using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BucleNumeral(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void BucleNumeral (int numero)
    {
        while (numero <= 100)
        {
            Debug.Log(numero);
            numero++;
        }
    }

}
