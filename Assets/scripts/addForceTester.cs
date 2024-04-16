using UnityEngine;

public class addForceTester : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float value;

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 input = new Vector2(x, y);

        rb.velocity += input * value * Time.fixedDeltaTime; // gyorsulás
        rb.velocity += input * value / rb.mass * Time.fixedDeltaTime; // erõhatás
        rb.AddForce(input * value, ForceMode2D.Force);        
    }
    private void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);
        if (jump)
            rb.velocity += Vector2.up * value / rb.mass; // lendület változás
        if (jump)
            rb.AddForce(Vector2.up * value, ForceMode2D.Impulse);
    }
}
