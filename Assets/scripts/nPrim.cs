using Unity.VisualScripting;
using UnityEngine;

public class nPrim : MonoBehaviour
{
    //for ciklus i valtozoja,
    //nNumberig, nNumber(a cel, pl elso 3 primszam: 3, 5, 7)
    [SerializeField] int nNumber;
    int oszt;
    //megnezni a for ciklus beadott valtozojat, hogy prim-e
    //1,2 tudjuk hogy nem,
    //3-nal belep az elso elagazasba, 4-nel nem
    //
    void Start()
    {
        //kezdje el kiirni a primszamokat, es amikor kiir egyet noveljen egy valtozot eggyel

        //i = talalt primszamok, nNumber = kivant prim db. szam
        for (int k = 0; k <= nNumber; k++)
        {
            for (int i = 3; k <= nNumber; i++)
            {
                for (int o = 2; o <= i; o++)
                {
                    if (i % o == 0)
                    {
                        o++;
                    }
                }
                if (oszt >= 2)
                {
                    i++;
                    Debug.Log($"{number} nem  primszam.");
                }
                else if (oszt < 2)
                {
                    Debug.Log($"{number} primszam.");
                }
            }
        }
            
    }
}
