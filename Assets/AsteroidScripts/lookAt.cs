using Unity.VisualScripting;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform toLookAt;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 self = transform.position;  // Saját
        Vector3 other = toLookAt.position;  // Másik (Amit nézek)

        Vector3 direction = other - self;
        direction.Normalize();

        if(direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);

        /*Vector3 step = direction * speed * Time.deltaTime;

        float stepLength = step.magnitude;
        float fullDistance = Vector3.Distance(self, other);
        if (stepLength > fullDistance)
        {
            step = direction * fullDistance;
        }

        transform.position += step;*/

        // transform.position = Vector3.MoveTowards(self, other, speed * Time.deltaTime);
    }
}
