using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float lifeTime = 2;
    int dmg = 10;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        HealthObject hasHealth = hit.GetComponent<HealthObject>();

        //damageable hasHealth = hit.GetComponent<damageable>();

        //float startingHealth = hasHealth.startingHealth;
        //float currentHealth = hasHealth.currentHealth;
        //float healtPercentage = currentHealth / startingHealth;

        if (hasHealth != null)
        {
            hasHealth.Damage(dmg);
            //hasHealth.reduceHealthbar();

            Destroy(gameObject);

            //Debug.Log($"{hit.gameObject}: {hasHealth.currentHealth} / {hasHealth.startingHealth} = {healtPercentage}, {hasHealth.currentHealth / hasHealth.startingHealth}");
        }
    }
}
