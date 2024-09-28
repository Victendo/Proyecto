using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMinimo;
    [SerializeField] float danhoMaximo;
    [SerializeField] int capacidadTotal = 50;
    [SerializeField] bool automatica;
    int municionActual;
    // Start is called before the first frame update
    void Start()
    {
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
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
