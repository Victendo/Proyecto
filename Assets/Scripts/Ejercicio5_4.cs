using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int dividendo = 69;
    [SerializeField] int divisor = 3;
    // Start is called before the first frame update
    void Start()
    {
        Division();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Division ()
    {
        int cociente = dividendo / divisor;
        if (cociente ==0)
        {
            Debug.Log("El divisor es 0.");
            Debug.Log("El cociente es  " + cociente);
        }
        else
        {
            Debug.Log("El divisor no es 0.");
        }
    }
}
