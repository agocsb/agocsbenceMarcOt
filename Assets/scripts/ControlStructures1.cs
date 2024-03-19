
using UnityEngine;

public class ControlStructures1 : MonoBehaviour
{
    [SerializeField] int anger = 0;

    private void Start()
    {
        int i = 1;
        while (i < 1000)
        {
            Debug.Log(i);
            i++;
        }
        //-----------------------------------------------------------
        for (int o = 0; o < 1000; o++)
        {
            Debug.Log(o);
        }


    }
    // Update is called once per frame
    void Update()
    {
        bool pressKey = Input.GetKeyDown(KeyCode.Space);

        if(pressKey)
        {
            anger++;
            if(anger > 3)
            {
                Debug.Log("Stop thumbing me shithead");
            }            
        }
       
       



    }
}
