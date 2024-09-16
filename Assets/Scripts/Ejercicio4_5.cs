using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCir = AreaCirculo(35.7f);
        Debug.Log("El area del circulo es de " + areaCir + " centimetros.");
        
        float areaTri = AreaTriangulo(55.8f, 39.2f);
        Debug.Log("El area del circulo es de " + areaTri + " centimetros.");

        float areaCua = AreaCuadrado(29.5f);
        Debug.Log("El area del cuadrado es de " + areaCua + " centimetros.");

        float circuloDolar = ConvertirCirculo(areaCir);
        Debug.Log("La conversion del area del circulo a dolares si fueran euros es de " + circuloDolar + " dolares.");
        
        float trianguloDolar = ConvertirTriangulo(areaTri);
        Debug.Log("La conversion del area del triangulo a dolares si fueran euros es de " + trianguloDolar + " dolares.");

        float cuadradoDolar = ConvertirCuadrado(areaCua);
        Debug.Log("La conversion del area del triangulo a dolares si fueran euros es de " + cuadradoDolar + " dolares.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     float AreaCirculo(float radioCirculo)
    {
        float areaTotalCir;
        areaTotalCir = (radioCirculo * 2.0f) / 3.14f;
        return areaTotalCir;
    }

    float AreaTriangulo(float baseTriangulo, float alturaTriangulo)
    {
        float areaTotalT;
        areaTotalT = (baseTriangulo * alturaTriangulo) / 2.0f;
        return areaTotalT;
    }

    float AreaCuadrado(float ladoCuadrado)
    {
        float areaTotalCua;
        areaTotalCua = ladoCuadrado * ladoCuadrado;
        return areaTotalCua;
    }

    float ConvertirCirculo(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }

    float ConvertirTriangulo(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }

    float ConvertirCuadrado(float cantidad)
    {

        float cambioDolar = cantidad * 1.11f;
        return cambioDolar;
    }


}
