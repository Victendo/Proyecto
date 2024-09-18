using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numMenor = 21;
    [SerializeField] int numMayor = 52;
    // Start is called before the first frame update
    void Start()
    {
        SubidonNumeral();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SubidonNumeral()
    {
        while (numMenor <= numMayor)
        {
            Debug.Log(numMenor);
            numMenor++;
        }
    }
}
