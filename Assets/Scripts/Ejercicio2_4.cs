using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El valor actual de vidas es: " + vidas);

        vidas += 77;

        Debug.Log("El primer valor actualizado de vidas es: " + vidas);

        vidas -= 3;

        Debug.Log("El segundo valor actualizado de vidas es: " + vidas);

        vidas *= 4;

        Debug.Log("El tercer valor actualizado de vidas es: " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
