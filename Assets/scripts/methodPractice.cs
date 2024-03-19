using UnityEngine;

public class methodPractice : MonoBehaviour
{    
    [SerializeField] int number;
    [SerializeField] float absNumber;
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int maxXY;
    [SerializeField] int powerBase;
    [SerializeField] int powerPower;
    [SerializeField] int Power;
    int Max(int a, int b)
    {
        int max;
        if (a > b)
            max = a;
        else
            max = b;
        return max;
    }

    float Abs(float number)
    {
        if (number < 0)
        {     
            return -number;
        }
        else
        {
            return number;
        }
    }
    /*int Pow(int b, int p)
    {
        
        while  (< p)
        {

        }

    }*/

    private void OnValidate()
    {
        absNumber = Abs(number);
        maxXY = Max(x, y);
        //Power = Pow(powerBase, powerPower);
    }

    void Start()
    {
        Debug.Log(Max(x, y));
    }

}
