using System.Collections;
using System.Collections.Generic;
//miert kell torolni?^
using UnityEngine;

public class MySecondScript : MonoBehaviour
{
    //miert kell az F?
    public float speed = 5.0F;
    private float xInput;
    private float zInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("x");
        zInput = Input.GetAxis("z");


        transform.Translate(Vector3.right * Time.deltaTime * speed * xInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * zInput);      
    }
}
