using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kilometros = 120.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La velocidad del coche es de " + kilometros + " kilometros por hora.");
        float metrosporSegundo = (kilometros * 1000.0f) / 3600.0f;

        Debug.Log("Por lo que son " + metrosporSegundo + " metros por segundo.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
