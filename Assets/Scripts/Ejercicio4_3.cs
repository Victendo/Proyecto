using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Convertir(5.34f, "euros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Convertir(float cantidad, string moneda)
    {

        float cambioDolar = cantidad * 1.11f;
        Debug.Log(cantidad + " " + moneda + " son " + cambioDolar + " dolares.");
    }
}
