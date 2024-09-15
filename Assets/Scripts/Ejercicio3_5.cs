using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio = 25.8f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El radio de la circunferencia es de " + radio + " cm de longitud.");

        float longitud = 2.0f * 3.14f * radio;
        Debug.Log("La longitud de la circunferencia es de " + longitud + " cm de longitud.");

        float area = 3.14f * radio * radio;
        Debug.Log("El area de la circunferencia es de " + area + " cm de longitud.");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
