using UnityEngine;

public class pitagorasziSzHaTeszt : MonoBehaviour
{
    [SerializeField] float a, b, c;
    [SerializeField] bool pita;
    [SerializeField] bool legyszivesNeSpammeldAKonzolt;

    private void Start()
    {
        legyszivesNeSpammeldAKonzolt = false;
    }
    private void OnValidate()
    {
        pita = false;        

        float aN = 0;
        float bN = 0;
        float cN = 0;

        aN = Mathf.Pow(a, 2);
        bN = Mathf.Pow(b, 2);
        cN = Mathf.Pow(c, 2);

        if(legyszivesNeSpammeldAKonzolt == true && aN + bN == cN)
        {
            pita = true;
            Debug.Log($"{a}, {b} és {c} pitagoraszi számhármas: {pita}");
        }

    }
}
