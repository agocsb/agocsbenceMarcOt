using UnityEngine;
public class step : MonoBehaviour
{
    [SerializeField] float speed = 5;    

    private void Start()
    {
        
    }

    void Update()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        Vector3 input = new Vector3(inputH, inputV, 0).normalized;  
        
        transform.position += input * speed * Time.deltaTime;

        /* Quaternion LastRotate = transform.rotation;

        if(inputV == 0 && 0 < inputH)
        {
            transform.Rotate(0, 0, -90);
            LastRotate = transform.rotation;
        }            
        if (inputV == 0 && 0 > inputH)
        {
            transform.Rotate(0, 0, 90);
            LastRotate = transform.rotation;
        }            



        if (inputH == 0 && 0 < inputV)
        {
            transform.Rotate(0, 0, 0);
            LastRotate = transform.rotation;
        }            
        if (inputH == 0 && 0 > inputV)
        {
            transform.Rotate(0, 0, -180);
            LastRotate = transform.rotation;
        }            

        if (inputV == 0 && 0 == inputH)
            transform.rotation = LastRotate;*/




        // Debug.Log($"{inputH}, {inputV}");
        // Debug.Log($"y = {y} ");
    }
}
