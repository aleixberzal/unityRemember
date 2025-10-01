using UnityEngine;
using UnityEngine.InputSystem;

public class projectileController : MonoBehaviour
{

  

    public float speed = 100f;
    public  CapsuleCollider coll;
    public Rigidbody rb;
    
    void Start()
    {


        coll = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();

        rb.linearVelocity = transform.up * speed;
    }

   


}
