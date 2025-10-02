using UnityEngine;

public class obstacleScorer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (scoreManager.instance != null)
        {

            scoreManager.instance.addPoints(-100);

        }
    }
}
