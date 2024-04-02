using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float speedLimit = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 0.5f;

    Vector3 velocity;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        // mozgas
        Vector3 step = velocity * Time.deltaTime * acceleration;
        transform.position += step;

        // forgatas
        transform.Rotate(0, 0, angularSpeed * -h * Time.fixedDeltaTime);
    }

    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) - pillanatszeru input lekerdezes nem valo fixed updatebe 
        //    Debug.Log("Bumm");

        float v = Input.GetAxisRaw("Vertical");

        // gyorsitas
        velocity += transform.up * v * Time.fixedDeltaTime;

        // lassitas
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        // max sebesseg
        velocity = Vector3.ClampMagnitude(velocity, speedLimit);

        // ----------------------------

        /*
        if (direction != Vector3.zero)
        {
            float rotation2D = transform.rotation.eulerAngles.z;  // 3D -> 2D
            float targetRotation = Vector2.SignedAngle(direction, Vector2.up);

            float nextRotation =
                Mathf.MoveTowardsAngle(rotation2D, targetRotation, Time.deltaTime * angularSpeed);

            transform.rotation = Quaternion.Euler(0, 0, nextRotation);  // 2D -> 3D
        }
        */
    }    
    /*
    using UnityEngine;

    public class Spaceship : MonoBehaviour
    {
    [SerializeField] float maxSpeed = 5;       // m/s
    [SerializeField] float acceleration = 5;   // m/s^2
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 0.5f;        // ???

    Vector3 velocity;

    void Update()
    {
        // Input
        float x = Input.GetAxisRaw("Horizontal");

        // Mozg�s
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        // Forgat�s
        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Input
        float y = Input.GetAxisRaw("Vertical");

        // Gyors�t�s
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        // Lass�t�s (K�zegellen�ll�s)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        // Max sebess�g
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}
 
     */
}