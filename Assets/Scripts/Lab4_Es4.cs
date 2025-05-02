using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Es4 : MonoBehaviour
{
    public int start = 5;
    public int ammount = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= ammount; i++)
        {
            
            Debug.Log(start);
            start++;
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
