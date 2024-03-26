using UnityEngine;

public class round : MonoBehaviour
{
    [SerializeField] float In = 0, floor, ceil, Nround;

    float Floor (float In)
    {
        if (In < 0)
        {
            In -= In % 1;
            return In;
        }
        else if(0 < In)
        {
            In -= In % 1;
            return In;
        }
        else
            return 0;
    }
    float Ceil (float In)
    {        
        float rest = In % 1;
        if (In < 0)
        {
            In = In - rest + 1;            
            return In;
        }
        else if (0 < In)
        {
            In = In - rest + 1;
            return In;
        }
        else
            return 0;
    }
    float Round (float In)
    {
        float rest = In % 1;
        if (In < 0)
        {
            if ((-0.5) <= rest)
            {
                In = rest + 1; 
                return In;
            }
            else
            {
                In = In - rest;
                return In;
            }
        }
        else if (0 < In)
        {
            if (0.5 <= rest)
            {
                In = In - rest + 1;
                return In;
            }
            else
            {
                In = In - rest;
                return In;
            }
        }
        else
            return 0;                    
    }

    void Start()
    {
        floor = Floor (In);
        ceil = Ceil (In);
        Nround = Round (In);
        Debug.Log($"{In} - {In % 1} + 1 = {ceil}");
    }
}
