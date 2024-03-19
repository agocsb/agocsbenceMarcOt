using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float speed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("x");
        float y = Input.GetAxisRaw("z");

        Vector3 direction = new(x, y);
        direction.Normalize();

        transform.position += direction * Time.deltaTime * speed;
    }
}
