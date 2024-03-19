using UnityEngine;

public class vampirArus : MonoBehaviour
{
    [SerializeField] float coins;
    [SerializeField] float health;

    int botP = 10; //price
    int torP = 4;
    int fogP = 13; 

    private void Start()
    {
        if (coins - botP >= 0) 
        {
            Debug.Log($"A bot x tied lehet aranyert cserebe");
            if (health - (botP * 5) > 0)
            {
                Debug.Log($"A bot x tied lehet eletpontert cserebe");
            }
        }
        else
        {
            Debug.Log($"A botot nem tudod megvasarolni");
        }
        //bunkok buzoganya
        if (coins - torP >= 0)
        {
            Debug.Log($"A tor x tied lehet aranyert cserebe");
            if (health - (torP * 5) > 0)
            {
                Debug.Log($"A tor x tied lehet eletpontert cserebe");
            }
        }
        else
        {
            Debug.Log($"A tort nem tudod megvasarolni");
        }
        //trukkos tor
        if (coins - fogP >= 0)
        {
            Debug.Log($"A fog x tied lehet aranyert cserebe");
            if (health - (fogP * 5) > 0)
            {
                Debug.Log($"A fog x tied lehet eletpontert cserebe");
            }
        }
        else
        {
            Debug.Log($"A fogat nem tudod megvasarolni");
        }
    }
}
