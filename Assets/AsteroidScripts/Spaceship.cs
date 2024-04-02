using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float speedLimit = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 180;

    Vector3 velocity;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //if(v != 0)        
        velocity += transform.up * v * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, speedLimit);
        

        Debug.Log($"h = {h}, v = {v}");        
        //direction.Normalize();

        Vector3 step = velocity * Time.deltaTime * acceleration;
        transform.position += step;

        transform.Rotate(0, 0, angularSpeed * -h * Time.deltaTime);

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
}