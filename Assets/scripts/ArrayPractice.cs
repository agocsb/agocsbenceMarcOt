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
    Transform Closest(Transform[] objects)
    {
        float minDistance = float.MaxValue;
        Transform closest = null;
        Vector3 self = transform.position;

        for (int i = 0; i < objects.Length; i++)
        {
            float distance = Vector3.Distance(self, objects[i].position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = objects[i];
            }
        }
        return closest;
    }
}
