using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int primerNumero = 4;
    [SerializeField] int segundoNumero = 2;
    // Start is called before the first frame update
    void Start()
    {
        ComparacionNumerica();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComparacionNumerica ()
    {
        if (primerNumero < 3 && segundoNumero < 3)
        {
            Debug.Log("Ambos numeros son menores que 3.");
        }

        else if (primerNumero !< 3 && segundoNumero !< 3)
        {
            Debug.Log("Ambos numeros son mayores que 3.");
        }

        else
        {
            Debug.Log("Hay un numero mayor que 3.");
        }
    }
}
