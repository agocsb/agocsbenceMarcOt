using UnityEngine;
using UnityEngine.UI;

public class damageable : MonoBehaviour
{
    public Slider healthBar;
    public float startingHealth = 100f;   
    public float currentHealth;    
    void Start()
    {
        currentHealth = startingHealth;        
    }

    void Update()
    {
        if(currentHealth <= 0)
            Destroy(gameObject);
    }
} 
