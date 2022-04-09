using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.


public class TP2 : MonoBehaviour
{
    public float producto1, producto2, producto3, monto;
    // Start is called before the first frame update
    void Start()
    {
    

        if (producto1 + producto2 + producto3 > monto)  
        {
            producto1 += (producto2 + producto3);

            producto1 -= monto;
            Debug.Log("No te alcanza,faltan:"+ producto1);   

        }

        else if (producto1+ producto2+ producto3 <= monto)
        {
            monto -= (producto1 + producto2 + producto3);
            Debug.Log("Te alcanza,sobran:"+monto);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
