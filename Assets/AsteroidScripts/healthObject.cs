using UnityEngine;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHp;
    [SerializeField] int collisionDamage;

    int currentHp;
    void Start()
    {
        currentHp = startHp;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }

    public void Damage(int damage)
    {
        if (damage < 0)
            return;

        currentHp -= damage;
        Debug.Log($"{nameof(gameObject)}: {currentHp}");

        if (currentHp <= 0)
            Destroy(gameObject);
    }



}