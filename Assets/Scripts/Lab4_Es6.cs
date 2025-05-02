using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Es6 : MonoBehaviour
{

    int[] GeneraArray()
    {
        int[] myArray = new int[20];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = Random.Range(0, 200);
            
        }

        return myArray;
    }

    void StampaArray()
    {
        int[] myArray = GeneraArray();

        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log("Prima funzione Elemento " + i + ": " + myArray[i]);
        }

    }

    void SommaArray()
    {
        int somma = 0;
        int[] myArray = GeneraArray();

        for (int i = 0; i< myArray.Length; i++) 
       
        {
           somma += myArray[i];   
        }

        Debug.Log("la somma dell'array è " + somma);
    }
    // Start is called before the first frame update
    void Start()
    {
        StampaArray();
        SommaArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
