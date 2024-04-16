using UnityEngine;

public class szorzotabla : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int o = 1; o <= 10; o++)
            {
                int p = i * o;
                Debug.Log($"{o} * {i} = {p}");
            }
        }
    }
}
// ezt sajnos nem latom at