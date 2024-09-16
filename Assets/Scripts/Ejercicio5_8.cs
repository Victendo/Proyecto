using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H = 18;
    [SerializeField] int M = 74;
    [SerializeField] int S = 36;
    // Start is called before the first frame update
    void Start()
    {
        DetectorDeHora();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetectorDeHora()
    {
        if (H < 0 || H >= 24 && M < 0 || M > 59 && S < 0 || S > 59)
        {
            Debug.Log("Esta hora es incorrecta");
        }

        else
        {
            Debug.Log("Esta hora es correcta");
        }
    }
}
