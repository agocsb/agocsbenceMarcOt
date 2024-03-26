using UnityEngine;

public class vectorHW : MonoBehaviour
{
    //vektor kivonas: honnan jussunk hova
    void Start()
    {
        
    }
    float Distance(Vector2 a, Vector2 b)
    {
        return (a - b).magnitude;
    }
    Vector3 NormalVectorAtoB(Vector3 a, Vector3 b)
    {
        return (b - a).normalized;
    }
}
