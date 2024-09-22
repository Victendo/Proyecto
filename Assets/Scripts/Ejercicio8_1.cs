using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_1 : MonoBehaviour
{
    [SerializeField] private string nombre;
    [SerializeField] private int vidaInicial;
    int vidaActual;
    [SerializeField] private float experiencia;
    [SerializeField]private bool final;
    [SerializeField] int da�oMinimo = 9;
    [SerializeField] int da�oMaximo = 15;
    [SerializeField] int capacidadTotal = 20;
    [SerializeField] bool automatica = false;
    int municionActual;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public bool Final { get => final; set => final = value; }
    public int VidaInicial { get => vidaInicial; set => vidaInicial = value; }
    public int Da�oMinimo { get => da�oMinimo; set => da�oMinimo = value; }
    public int Da�oMaximo { get => da�oMaximo; set => da�oMaximo = value; }
    public int CapacidadTotal { get => capacidadTotal; set => capacidadTotal = value; }
    public bool Automatica { get => automatica; set => automatica = value; }
    public int MunicionActual { get => municionActual; set => municionActual = value; }
    public int VidaActual { get => vidaActual; set => vidaActual = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel()
    {
        float nivel = experiencia / 1000;
        return nivel;
    }

    public void PrepararPersonaje()
    {
        if (Input.GetKeyDown(KeyCode.Space) && final == false)
        {
             Debug.Log("Nombre: " + nombre);
                Debug.Log("Vida: " + vidaInicial);
                Debug.Log("Experiencia: " + experiencia);
                Debug.Log("Nivel: " + CalcularNivel());
                final = true;
        }
        if (final == true)
        {
            Debug.Log("yaEjecutado");
        }
    }

    public void SistemaDeVida()
    {
        float cura = RecibirCura();
        float da�o = RecibirDa�o();
    }
    public float RecibirCura()
    {
        vidaActual = vidaInicial + 8;
        vidaInicial = vidaActual;
        if (vidaActual >= 0)
        {
            return vidaActual;
        }
        else
        {
            vidaActual = -1;
            return vidaActual;
        }
        
    }

    public float RecibirDa�o()
    {
        vidaActual = vidaInicial - 5;
        vidaInicial = vidaActual;
        if (vidaActual == 0)
        {
            return vidaActual;
        }
        else if (vidaActual < 0)
        {
            vidaActual = -1;
            return vidaActual;
        }

        else
        {
            return vidaActual;
        }

    }

    public void Arma()
    {
        municionActual = capacidadTotal;
        float UsoArma = UtilizarArma();
        float Recarga = RecargarArma();
    }

    public float UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            return 0;
        }
        else
        {

            return -1;
        }
    }

    public float RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            return 0;
        }
        else
        {
            return -1;
        }
    }
    }
