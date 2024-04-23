using UnityEngine;

public class startAsteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float maxAngularSpeed = 90;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed);

        Vector2 velocity = Random.insideUnitCircle * maxSpeed;

        rb.velocity = velocity;
    }
    void OnDestroy()
    {
        FindObjectOfType<asteroidManager>().RemoveAsteroid(this);    
    }
}
