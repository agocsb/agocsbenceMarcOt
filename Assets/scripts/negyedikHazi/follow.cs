using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 1; //sokkal gyorsabb a follow mint a step pedig ugyan ugy csak egy iranyvektor, azonos szamertek es deltaTime szorzataval novelem a positionjuket
    [SerializeField] float minDistance = 15;
    void Update()
    {
        Vector3 distance = target.position - transform.position;
        
        float curDistance = distance.magnitude;
        if (curDistance <= minDistance)
            return;

        transform.position += speed * Time.deltaTime * distance.normalized;
    } 
}
