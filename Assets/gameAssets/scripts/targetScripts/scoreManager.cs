using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{

    public static scoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }
    public void addPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
