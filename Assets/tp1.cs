using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
public class tp1 : MonoBehaviour
{
    public int Numero1,Numero2;
        
    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 == Numero2)
        {
            Debug.Log("Numero 1 es igual a Numero 2");
    
        }
        if (Numero1 != Numero2)
        {
            Debug.Log("Numero 1 no es igual a Numero 2");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
