using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp = 200;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El nivel de exp es: " + exp);
        int nivel = 32 + (9 * exp / 5);
        Debug.Log("Por lo que su nivel actual es: " + nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
