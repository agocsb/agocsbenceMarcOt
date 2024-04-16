using UnityEngine;

public class followCloserOne : MonoBehaviour
{
    [SerializeField] float speed = 5;
    //[SerializeField] float minDistance = 5;
    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;
    void Update()
    {
        Vector3 distancePlayer = Target1.position - transform.position;
        float distancePlayerF = distancePlayer.magnitude;
        Vector3 distanceBait = Target2.position - transform.position;
        float distanceBaitF = distanceBait.magnitude;

        if (distanceBaitF > distancePlayerF)
            transform.position += distancePlayer.normalized * speed * Time.deltaTime;
        if (distanceBaitF < distancePlayerF)
            transform.position += distanceBait.normalized * speed * Time.deltaTime;

        //itt is ugy ugrik ra a playerre mintha nem lenne ott a deltaTime, sokkal gyorsabban mint ahogyan a player meg tud mozdulni, pedig csak a speed valtozo LEHETNE mas a ket transform.position valtozasban
        //normalizalni kellett a distance vektort

    }
}
