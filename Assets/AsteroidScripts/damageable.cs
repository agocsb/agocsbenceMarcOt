using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class damageable : MonoBehaviour
{
    public Slider healthBar;
    public float startingHealth = 100f;   
    public float currentHealth;

    int collisionDamage;
    void Start()
    {
        currentHealth = startingHealth;        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        takeDamage(collisionDamage);
    }

    public void takeDamage(int damage)
    {
        damage = damage < 0 ? 0 : damage;
        //if (damage < 0) damage = 0;
        currentHealth -= damage;
        //Debug.Log($"{ currentHealth}, { startingHealth}");
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
    public void reduceHealthbar()
    {
        healthBar.value = currentHealth / startingHealth;
        //Debug.Log(healthBar.value);
    }    
} 
