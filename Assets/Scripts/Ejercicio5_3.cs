using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numeroEntero = 5;
    // Start is called before the first frame update
    void Start()
    {
        ComprobarNumero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComprobarNumero ()
    {
        if (numeroEntero>=0 && numeroEntero<= 9)
        {
            Debug.Log("Este numero se encuentra entre el 0 y el 9");
        }

        else
        {
            Debug.Log("Este numero no se encuentra entre el 0 y el 9");
        }
    }
}
