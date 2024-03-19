using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float K, T;
    // Start is called before the first frame update
    void OnValidate()
    {
        float pi = Mathf.PI;
        K = 2 * radius * pi;
        T = Mathf.Pow(radius, 2) * pi;

    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
