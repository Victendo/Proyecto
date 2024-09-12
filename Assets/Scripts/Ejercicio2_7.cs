using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int monedas = 7;
    int segundo = 1;
    int horaEnSegundos = 3600;
    int monedasConseguidas;

    // Start is called before the first frame update
    void Start()
    {
        monedasConseguidas = monedas * horaEnSegundos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
