using UnityEngine;

public class vectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 myVector = new(2, 3);
        float x = myVector.x;
        float y = myVector.y;

        Vector2 myOtherVector = new(3, 9);

        Vector2 summa = myVector + myOtherVector; //(5, 12) 
        Vector2 diff = myVector - myOtherVector; //(-1, -6)
        Vector2 mult = diff * 5; //(-5, -30)                                                 
        Vector2 div = summa / 2; //(2.5, 6)

        float vectorLength = summa.magnitude; //gyok180

        Vector2 normalised = summa.normalized; //

    }
}
