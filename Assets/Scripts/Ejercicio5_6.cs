using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivelPokemon = 60;
    // Start is called before the first frame update
    void Start()
    {
        PruebaMultiplo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PruebaMultiplo ()
    {
        int divisor = nivelPokemon % 10;
        if (divisor == 0)
        {
            Debug.Log("El nivel de tu Pokemon es multiplo de 10");
        }

        else
        {
            Debug.Log("El nivel de tu Pokemon no es multiplo de 10");
        }

    }
}
