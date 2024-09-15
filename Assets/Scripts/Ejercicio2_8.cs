using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float puntos = 120.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tu personaje tiene " + puntos + " puntos de vida.");
        Debug.Log("Oh no! Tu personaje ha sido envenenado.");
        puntos -= (puntos * 3) / 100;

        Debug.Log("Primer turno. Tu personaje tiene ahora " + puntos + " puntos de vida");
        puntos -= (puntos * 6) / 100;

        Debug.Log("Segundo turno. Tu personaje tiene ahora " + puntos + " puntos de vida");
        puntos -= (puntos * 9) / 100;

        Debug.Log("Tercer turno. Tu personaje tiene ahora " + puntos + " puntos de vida");
        puntos -= (puntos * 12) / 100;

        Debug.Log("Cuarto turno. Tu personaje tiene ahora " + puntos + " puntos de vida");
        puntos -= (puntos * 15) / 100;

        Debug.Log("Quinto turno. Tu personaje tiene ahora " + puntos + " puntos de vida");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
