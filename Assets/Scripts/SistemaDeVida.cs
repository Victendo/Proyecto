using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{

    //EJERCICIO 8.2

    [SerializeField] float vidaInicial;
    float vidaActual;

    public float VidaInicial { get => vidaInicial; set => vidaInicial = value; }
    public float VidaActual { get => vidaActual; set => vidaActual = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static float RecibirCura(float cantidad, float vidaReciente)
    {
        vidaReciente = vidaReciente + cantidad;
        if (vidaReciente >= 0)
        {
            return vidaReciente;
        }
        else
        {
            return -1;
        }
    }

    public void Cura()
    {
        float cura = RecibirCura(35.0f, vidaActual);
        Debug.Log("El personaje ha recibido una cura. Ahora su vida actual es: " + cura);
    }

    public static float RecibirDanho(float cantidad, float vidaReciente)
    {
        vidaReciente = vidaReciente - cantidad;
        if (vidaReciente >= 0)
        {
            return vidaReciente;
        }

        else if (vidaReciente == 0)
        {
            return 0;
        }

        else
        {
            return -1;
        }
    }

    public void Danho()
    {
        float danho = RecibirDanho(25.0f, vidaActual);
        Debug.Log("El personaje ha recibido daño. Ahora su vida actual es: " + danho);
    }

}
