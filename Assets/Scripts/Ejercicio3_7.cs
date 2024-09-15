using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseTriangulo = 45.7f;
    [SerializeField] float alturaTriangulo = 82.4f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La base del triangulo es de " + baseTriangulo + " centimetros y la altura es de " 
            + alturaTriangulo + " centimetros.");

        float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log("El area del triangulo es de " + areaTriangulo + " centimetros.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
