using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Es2 : MonoBehaviour
{
    //Dichiaro un array di quattro numeri 
    
    int [] myArray = new int [4];

    
    // Start is called before the first frame update
    void Start()
    {
        myArray[0] = 23;
        myArray[1] = 28;
        myArray[2] = 45;
        myArray[3] = 6;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (i == 2)
            {
                break;
            }
            else
            {
                int somma = +myArray[i];

                int prodotto = myArray[i] * myArray[i + 1];

                Debug.Log("la somma è " + somma);
                Debug.Log("il Prodotto è " + prodotto);

            }

              
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
