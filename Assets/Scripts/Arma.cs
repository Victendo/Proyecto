using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    //EJERCICIO 8.3 / EJERCICIO 8.4 


    [SerializeField] float danhoMinimo;
    [SerializeField] float danhoMaximo;
    [SerializeField] int capacidadTotal = 50;
    [SerializeField] bool automatica;
    int municionActual;

    public float DanhoMinimo { get => danhoMinimo; set => danhoMinimo = value; }
    public float DanhoMaximo { get => danhoMaximo; set => danhoMaximo = value; }
    public int CapacidadTotal { get => capacidadTotal; set => capacidadTotal = value; }
    public bool Automatica { get => automatica; set => automatica = value; }

    // Start is called before the first frame update
    void Start()
    {
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResultadoUso()
    {
        float posibleUso = UtilizarArma();
        if (posibleUso == 0)
        {
            Debug.Log("Disparo conseguido");
        }
        if (posibleUso== -1)
        {
            Debug.Log("El disparo no ha sido posible. RELOAD!!!");
        }
    }


    public int UtilizarArma()
    {
        municionActual--;
        if (municionActual >= 0)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public void ResultadoRecarga()
    {
        float posibleRecarga = RecargarArma();
        if (posibleRecarga == 0)
        {
            Debug.Log("Recarga conseguida");
        }
        if (posibleRecarga == -1)
        {
            Debug.Log("Arma ya cargada.");
        }
    }

    public int RecargarArma()
    {
        municionActual = capacidadTotal;

        if (municionActual == capacidadTotal)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }


}
