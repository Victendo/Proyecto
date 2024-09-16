using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int primeraVelocidad = 58;
    [SerializeField] int segundaVelocidad = 75;
    [SerializeField] int terceraVelocidad = 48;
    // Start is called before the first frame update
    void Start()
    {
        PruebaVelocidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PruebaVelocidad()
    {
        if (primeraVelocidad > segundaVelocidad && primeraVelocidad > terceraVelocidad)
        {
            Debug.Log("El primero en atacar es el primer jugador");
        }

        else if (segundaVelocidad > primeraVelocidad && segundaVelocidad > terceraVelocidad)
        {
            Debug.Log("El primero en atacar es el segundo jugador");
        }

        else
        {
            Debug.Log("El primero en atacar es el tercer jugador");
        }
    }
}
