using UnityEngine;
using UnityEngine.InputSystem;

public class projectileController : MonoBehaviour
{

  

    public float speed = 100f;
    public Rigidbody rb;
    
    void Start()
    {


        rb = GetComponent<Rigidbody>();

        rb.linearVelocity = transform.up * speed;
    }

   


}
