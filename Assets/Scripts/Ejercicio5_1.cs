using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Batalla(45, 79);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Batalla (int vidaUno, int vidaDos)
    {
        if (vidaUno == vidaDos)
        {
            Debug.Log("Los luchadores estan igualados");
        }
        else
        {
            Debug.Log("Los luchadores estan desigualados");
        }
    }
}
