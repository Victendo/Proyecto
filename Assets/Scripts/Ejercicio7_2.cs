using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BucleNumeral();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void BucleNumeral()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }
}
