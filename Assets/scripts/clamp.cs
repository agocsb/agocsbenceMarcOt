using UnityEngine;

public class clamp : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float In;
    [SerializeField] float bIn;


    float Clamp(float In)
    {
        if (min < In && In < max)
            return In;
        else if (In <= min)
            return min;
        else if (max <= In)
            return max;
        else
            return 0;
    }
    float bClamp(float bIn)
    {
        if (bIn <= 0)
            return 0;
        else if (1 <= bIn)
            return 1;
        else
            return bIn;
    }


    void Start()
    {
        if(max < min)        
            (min, max) = (max, min);
        In = Clamp(In);
        bIn = bClamp(In);
    }
    void OnValidate()
    {
         
    }
}
