using UnityEngine;

public class screenTeleporter : MonoBehaviour
{
    Collider2D colliderTwoD;
    SpriteRenderer spriteRenderer;
    Camera camera;
    
    void Start()
    {
        colliderTwoD = GetComponent<Collider2D>(); 
        spriteRenderer = GetComponent<SpriteRenderer>();
        //komponensek eltarolasa
        camera = Camera.main;
        //kamera eltarolasa
    }

    void Update()
    {
        Vector2 cameraPos = camera.transform.position;
        Vector2 cameraSize = new Vector2(camera.orthographicSize * camera.aspect, camera.orthographicSize);

        Rect cameraRect = new Rect(cameraPos - cameraSize, cameraSize * 2);
        Bounds objectBounds;
    }

    void OnDrawGizmos()
    {
        if (spriteRenderer == null)
            return;

        Bounds bounds = colliderTwoD.bounds;

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
