using UnityEngine;

public class osszegzes : MonoBehaviour
{
    // nincs mathf fuggveny x faktorialisra ???
    [SerializeField] float number = 0;
    [SerializeField] float sum = 0;
     void Start() //az osszeadasos feladatban felmerulo problema miatt Start, Onvalidate helyett 
        //ha az OnValidate legelejen nullazzuk x summat, akkor meg lehet abban is jeleniteni
    {
        for (int i = 0; i <= number; i++) 
        {
            sum += i;
        }
        Debug.Log($"Elso {number} szam osszege {sum}");
    }
}
