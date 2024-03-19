using UnityEngine;

public class fizzBuzz : MonoBehaviour
{
    [SerializeField] float number;
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Debug.Log($"Fizz");
            }
            else if (i % 5 == 0 && i % 3 != 0)
            {
                Debug.Log($"Buzz");
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                Debug.Log($"FizzBuzz");
            }
           else
           {
                Debug.Log(i);
           }
        }
    }
}
