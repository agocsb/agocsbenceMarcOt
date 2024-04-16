using UnityEngine;

public class primTeszt : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField]int o = 0; //osztok szama az egyen kivul
    void Start()
    {
        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                o++;
            }            
        }
        if (o >= 2)
        {
            Debug.Log($"{number} nem  primszam.");
        }
        else if (o < 2)
        {
            Debug.Log($"{number} primszam.");
        }
    }


}
