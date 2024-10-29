using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score;
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        Instance = this;
    }
    public void AddScore(int matchCount)
    {
        int points = matchCount * 10;
        score += points;
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}