using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DeKMHaMS(140);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeKMHaMS (int kilometros)
    {
        int horaEnSegundos = 3600;
        float metrosPorSegundo = (kilometros * 1000) / horaEnSegundos;
        Debug.Log(kilometros + " por hora son " + metrosPorSegundo + " metros por segundo.");
    }
}
