using UnityEngine;

public class primTeszt2 : MonoBehaviour
{
    [SerializeField] int number;
    //[SerializeField] int o = 0; //osztok szama az egyen kivul
    [SerializeField] bool prim;
    void OnValidate()
    {
        prim = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                prim = false;
                break;
            }
        }
        

        /*if (o >= 2)
        {
            Debug.Log($"{number} nem  primszam.");
        }
        else if (o < 2)
        {
            Debug.Log($"{number} primszam.");
        }*/
    }
}
