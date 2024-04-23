using System.Collections.Generic;
using UnityEngine;

public class listPractice : MonoBehaviour
{
    List<string> myList = new();

    void Start()
    {
        myList.Add("A");
        myList.Add("B");
        myList.Add("C");

        myList.Remove("A");
    }

    void Update()
    {
        
    }
}
