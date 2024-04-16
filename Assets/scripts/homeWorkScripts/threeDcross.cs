using UnityEngine;
using UnityEngine.UIElements;

public class threeDcross : MonoBehaviour
{
    /*[SerializeField] Color colorX;
    [SerializeField] Color colorY;
    [SerializeField] Color colorZ;
    [SerializeField] float axisX = 5;
    [SerializeField] float axisY = 5;
    [SerializeField] float axisZ = 5;*/

    [SerializeField] float length = 0.5f;  // Egy ág hossza


    void Start()
    {
        
    }
    void Update()
    {
        
    }
    /*private void OnDrawGizmos()
    {
        Gizmos.color = colorX;
        Gizmos.DrawLine(transform.position - transform.right * axisX, transform.position + transform.right * axisX);

    }*/
    void OnDrawGizmos()
    {
        Vector3 p = transform.position;              // Középpont

        // X tengely
        Gizmos.color = Color.red;                    // Gizmó színe
        Vector3 right = length * transform.right;    // Lokális joobbra irány
        Gizmos.DrawLine(p - right, p + right);       // Vonal rajzolása
        Gizmos.DrawSphere(p + right, length / 3);        // Gömb rajzoása 

        // Y tengely
        Gizmos.color = Color.green;
        Vector3 up = length * transform.up;
        Gizmos.DrawLine(p - up, p + up);
        Gizmos.DrawSphere(p + up, length / 3);

        // Z tengely
        Gizmos.color = Color.blue;
        Vector3 forward = length * transform.forward;
        Gizmos.DrawLine(p - forward, p + forward);
        Gizmos.DrawSphere(p + forward, length / 4);

        // Hmmm... Kicsit sok a kódisméttlés. Mit kezdjünk ezzel?
    }
}
