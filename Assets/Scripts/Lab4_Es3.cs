using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Es3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            int numero = Random.Range( 0, 100 );

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log("FuzzBuzz");
            }

            else if (numero % 3 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (numero % 5 == 0)
            {
                Debug.Log("Fuzz");
            }
            else
            {
                Debug.Log(numero);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
    
