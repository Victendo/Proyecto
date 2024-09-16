using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo(35.7f);
        AreaTriangulo(55.8f, 39.2f);
        AreaCuadrado(29.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float AreaCirculo (float radioCirculo)
    {
        Debug.Log("El radio del circulo es de " + radioCirculo + " centimetros.");
        float areaTotalCir;
        areaTotalCir = (radioCirculo * 2.0f) / 3.14f;
        Debug.Log("El area del circulo es de " + areaTotalCir + " centimetros.");
        return areaTotalCir;
    }

    float AreaTriangulo(float baseTriangulo, float alturaTriangulo)
    {
        Debug.Log("La base del triangulo es de " + baseTriangulo + " centimetros, mientras que la altura del triangulo es de " + alturaTriangulo + " centimetros.");
        float areaTotalT;
        areaTotalT = (baseTriangulo * alturaTriangulo) / 2.0f;
        Debug.Log("El area del circulo es de " + areaTotalT + " centimetros.");
        return areaTotalT;
    }

    float AreaCuadrado(float ladoCuadrado)
    {
        Debug.Log("El lado del cuadrado es de " + ladoCuadrado + " centimetros.");
        float areaTotalCua;
        areaTotalCua = ladoCuadrado * ladoCuadrado;
        Debug.Log("El area del circulo es de " + areaTotalCua + " centimetros.");
        return areaTotalCua;
    }
}
