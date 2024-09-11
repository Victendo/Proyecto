using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 3, vidasPlayer2 = 15, vidasPlayer3 = 7, vidasPlayer4 = 11;
    int checkpoint2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El valor actual de Player1 es: " + vidasPlayer1);
        Debug.Log("El valor actual de Player2 es: " + vidasPlayer2);
        Debug.Log("El valor actual de Player3 es: " + vidasPlayer3);
        Debug.Log("El valor actual de Player4 es: " + vidasPlayer4);

        checkpoint2 = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = checkpoint2;

        Debug.Log("El nuevo valor de Player1 es: " + vidasPlayer1);
        Debug.Log("El nuevo valor de Player2 es: " + vidasPlayer2);
        Debug.Log("El nuevo valor de Player3 es: " + vidasPlayer3);
        Debug.Log("El nuevo valor de Player4 es: " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
