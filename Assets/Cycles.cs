using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(Mathf.Pow(i, 2));
        }
        for (int k = 1; k <= 99; k++)
        {
            int prt = k % 2;
            if (prt == 1)
            {
                Debug.Log(k);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
