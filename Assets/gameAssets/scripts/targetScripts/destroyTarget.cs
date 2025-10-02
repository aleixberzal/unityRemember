using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyTarget : MonoBehaviour
{

    public bool isSpecial = false;
    void OnTriggerEnter(Collider other)
    {
        if (scoreManager.instance != null)
        {
            if (isSpecial)
            {
                scoreManager.instance.addPoints(500);

            }
            else
            {
                scoreManager.instance.addPoints(100);

            }

        }

        Destroy(gameObject);
    }

}
