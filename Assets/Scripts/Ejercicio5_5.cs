using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] float nivelPersonaje = 48.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ParoImpar ()
    {
        float pruebaNivel = nivelPersonaje % 2;
        if (pruebaNivel == 0 )
        {
            Debug.Log("El nivel del personaje es par.");
        }

        else
        {
            Debug.Log("El nivel del personaje es impar.");
        }
    }
}
