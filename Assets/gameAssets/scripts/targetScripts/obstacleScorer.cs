using UnityEngine;

public class obstacleScorer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (scoreManager.instance != null)
        {

            scoreManager.instance.addPoints(-100);

        }
    }
}
