using UnityEngine;

public class arrayPractice3 : MonoBehaviour
{
    [SerializeField] int[] numbers;
    [SerializeField] int max;

    private void OnValidate()
    {
        // max = Mathf.Max(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }
    }
}
