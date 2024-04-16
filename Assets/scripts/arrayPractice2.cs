using UnityEngine;

public class arrayPractice2 : MonoBehaviour
{
    [SerializeField] string[] numbers;
    [SerializeField] int count;

    private void OnValidate()
    {
        numbers = new string[count];
        if(count == 4)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                string st = "";
                for (int o = 0; o < i + 1; o++)
                {
                    st += (i + 1);
                }
                numbers[i] = st;
            }
        }
    }

}
