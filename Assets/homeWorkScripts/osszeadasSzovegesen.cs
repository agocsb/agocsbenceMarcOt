using UnityEngine;

public class osszeadasSzovegesen : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] string text;
    // lehet egy sorban deklaralni
    int c;

    void OnValidate() //ha 45ot irnek be, kiirja x 4 + 0 = 4et majd x 45 + 0 = 45ot
    {
        c = a + b;
        text = $"{a} + {b} =\n= {c}"; // ($"{x} + {y}") {} stringen belul, $ elso idezojel elott: nem kell megszakitani az idezojelet x valtozoknal
        // Debug.Log("Give in numbers A and B !");
       
        /*if (c != 0)
        Debug.Log(text);*/
    } 
    /*void Start()
    {
        c = x + y;
        string text = ($"{x} + {y} = {c}");
    }*/
}
