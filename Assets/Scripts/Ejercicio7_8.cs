using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int primerNumero = 7;
    [SerializeField] int segundoNumero = 39;
    // Start is called before the first frame update
    void Start()
    {
        BuclePares();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuclePares()
    {
        {
            for (int i = primerNumero; i < segundoNumero; i++)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }
}
