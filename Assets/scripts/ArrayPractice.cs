
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] numbers;
    private void OnValidate()
    {
        numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers.Length - i;
        }
    }
}
