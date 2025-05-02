using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Lab4_Es5 : MonoBehaviour
{
    public int find = 0;
    int[] myArray;
    // Start is called before the first frame update
    void Start()
    {
        int lunghezza = Random.Range(0, 200);
        myArray = new int[lunghezza];
        for (int i = 0; i < lunghezza; i++) 
        {
            myArray[i] = Random.Range(0, 200);

            if (myArray[i] == find)
            {
                Debug.Log("Find!");
            }

            else
            {
                Debug.Log("i did not find anything");
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
