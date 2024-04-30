using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHp;
    [SerializeField] int collisionDamage;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] TMP_Text healthText;


    int currentHp;

    bool isSetup = false;

    private void OnValidate()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        currentHp = startHp;
        updateHealthUI();
        isSetup = true;
    }    

    void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }

    public void Damage(int damage)
    {
        if (isSetup != true) return;
        if (damage < 0) return;

        currentHp -= damage;

        updateHealthUI();

        updateSprite();
       
        //Debug.Log($"{nameof(gameObject)}: {currentHp}");

        if (currentHp <= 0)
            Destroy(gameObject);
    }

    void updateSprite()
    {
        if (spriteRenderer == null) return;
        if (sprites == null || sprites.Count == 0) return;

        float healthRate = (float)currentHp / startHp;
        healthRate = 1 - healthRate;
        int index = Mathf.RoundToInt(healthRate * (sprites.Count - 1));
        spriteRenderer.sprite = sprites[index]; 
    }
    void updateHealthUI()
    {
        if (healthText != null)
            healthText.text = "Health: " + currentHp;
    }
}