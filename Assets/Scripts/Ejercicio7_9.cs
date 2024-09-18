using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numeroMultiplo = 73;
    // Start is called before the first frame update
    void Start()
    {
        BucleMultiplo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BucleMultiplo()
    {
        for (int i = 1; i <= numeroMultiplo; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
