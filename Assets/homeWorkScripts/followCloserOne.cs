using UnityEngine;

public class followCloserOne : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float minDistance = 5;
    [SerializeField] Transform playerTarget;
    [SerializeField] Transform baitTarget;
    void Update()
    {
        Vector3 distancePlayer = playerTarget.position - transform.position;
        float distancePlayerF = distancePlayer.magnitude;
        Vector3 distanceBait = baitTarget.position - transform.position;
        float distanceBaitF = distanceBait.magnitude;

        if (distanceBaitF > distancePlayerF)
            transform.position += distancePlayer * speed * Time.deltaTime;
        if (distanceBaitF < distancePlayerF)
            transform.position += distanceBait * speed * Time.deltaTime;

        // itt is ugy ugrik ra a playerre mintha nem lenne ott a deltaTime, sokkal gyorsabban mint ahogyan a player meg tud mozdulni, pedig csak a speed valtozo LEHETNE mas a ket transform.position valtozasban

    }
}
