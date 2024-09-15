using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numeroEntero = 420;
    // Start is called before the first frame update
    void Start()
    {
        int doble = numeroEntero * 2;
        int triple = numeroEntero * 3;
        Debug.Log("Doble de " + numeroEntero + ": " + doble);
        Debug.Log("Triple de " + numeroEntero + ": " + triple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
