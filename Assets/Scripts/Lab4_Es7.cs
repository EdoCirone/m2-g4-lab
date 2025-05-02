using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Es7 : MonoBehaviour
{
    public int minimo = 10;
    public int massimo = 50;

    int[] myArray = new int[20]; // Array usato da tutti i metodi

    int[] GeneraArray(int[] array, int b, int c)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(b, c);
        }

        return array;
    }

    void StampaArray()
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log("Elemento " + i + ": " + myArray[i]);
        }
    }

    void SommaArray()
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
        myArray = GeneraArray(myArray, minimo, massimo); // genera una volta sola
        StampaArray();
        SommaArray();
    }

    void Update()
    {

    }
}