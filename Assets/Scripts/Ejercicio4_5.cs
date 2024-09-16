using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCir = areaCirculo(35.7f);
        Debug.Log("El area del circulo es de " + areaCir + " centimetros.");
        
        float areaTri = areaTriangulo(55.8f, 39.2f);
        Debug.Log("El area del circulo es de " + areaTri + " centimetros.");

        float areaCua = areaCuadrado(29.5f);
        Debug.Log("El area del cuadrado es de " + areaCua + " centimetros.");

        float circuloDolar = convertirCirculo(areaCir);
        Debug.Log("La conversion del area del circulo a dolares si fueran euros es de " + circuloDolar + " dolares.");
        
        float trianguloDolar = convertirTriangulo(areaTri);
        Debug.Log("La conversion del area del triangulo a dolares si fueran euros es de " + trianguloDolar + " dolares.");

        float cuadradoDolar = convertirCuadrado(areaCua);
        Debug.Log("La conversion del area del triangulo a dolares si fueran euros es de " + cuadradoDolar + " dolares.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     float areaCirculo(float radioCirculo)
    {
        float areaTotalCir;
        areaTotalCir = (radioCirculo * 2.0f) / 3.14f;
        return areaTotalCir;
    }

    float areaTriangulo(float baseTriangulo, float alturaTriangulo)
    {
        float areaTotalT;
        areaTotalT = (baseTriangulo * alturaTriangulo) / 2.0f;
        return areaTotalT;
    }

    float areaCuadrado(float ladoCuadrado)
    {
        float areaTotalCua;
        areaTotalCua = ladoCuadrado * ladoCuadrado;
        return areaTotalCua;
    }

    float convertirCirculo(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }

    float convertirTriangulo(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }

    float convertirCuadrado(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }


}
