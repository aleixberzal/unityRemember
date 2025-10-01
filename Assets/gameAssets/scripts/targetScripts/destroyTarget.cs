using UnityEngine;

public class destroyTarget : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}
