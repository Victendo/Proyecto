using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BucleNumeral(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BucleNumeral(int numero)
    {
        while (numero >= 1)
        {
            Debug.Log(numero);
            numero--;
        }
    }
}
