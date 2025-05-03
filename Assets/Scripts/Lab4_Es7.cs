using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lab4_Es7 : MonoBehaviour
{
    public int minimo = 10;
    public int massimo = 50;
    public int lunghezza = 0;


    int[] GeneraArray(int[] array, int b, int c)
    {

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(b, c);
        }

        return array;
    }

    void StampaArray(int[] myArray)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log("Elemento " + i + ": " + myArray[i]);
        }
    }

    void SommaArray(int[] myArray)
    {
        int somma = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            somma += myArray[i];
        }

        Debug.Log("La somma dell'array è " + somma);
    }

    void Start()
    {
        int[] myArray = new int[lunghezza];
        GeneraArray(myArray, minimo, massimo);
        StampaArray(myArray);
        SommaArray(myArray);
    }

    void Update()
    {

    }
}