using UnityEngine;

public class vampirArus2 : MonoBehaviour
{
    [SerializeField] int coins = 10;
    [SerializeField] int health = 20;
    [SerializeField] int botPrice = 10;
    [SerializeField] int torPrice = 4;
    [SerializeField] int fogPrice = 13;
    [SerializeField] bool canBuyBot, canBuyTor, canBuyFog;
    void OnValidate()
    {
        canBuyBot = botPrice <= coins || botPrice * 5 < health;
        canBuyTor = torPrice <= coins || torPrice * 5 < health;
        canBuyFog = fogPrice <= coins || fogPrice * 5 < health;
    }
}