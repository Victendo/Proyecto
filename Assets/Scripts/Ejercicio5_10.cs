using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float temperatura = 24.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Termometro ()
    {
        if (temperatura <= 10)
        {
            Debug.Log("Frio.");
        }

        else if (temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Nublado.");
        }

        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Caluroso.");
        }

        else
        {
            Debug.Log("Tropical.");
        }
    }
}
