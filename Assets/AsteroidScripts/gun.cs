using UnityEngine;
using UnityEngine.UIElements;

public class gun : MonoBehaviour
{
    CircleCollider2D projectileCollider;
    PolygonCollider2D spaceshipCollider;
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject spaceship;

    void Start()
    {
        projectileCollider = projectile.GetComponent<CircleCollider2D>();
        float projectileRadius = projectileCollider.radius;
        spaceshipCollider = spaceship.GetComponent<PolygonCollider2D>();
        float spaceshipRadius = spaceshipCollider.bounds.size.y / 2;

        //transform.position = spaceship.transform.position + spaceship.transform.up * (spaceshipRadius + projectileRadius);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newProjectile = Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
