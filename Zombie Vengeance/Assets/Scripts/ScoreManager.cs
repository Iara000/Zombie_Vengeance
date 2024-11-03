using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score;
    public TextMeshProUGUI scoreText;
    private int nextSceneLoad;
    public int scoreGoal;
    public float totalTime;
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Awake()
    {
        Instance = this;
    }
    public void AddScore(int matchCount)
    {
        int points = matchCount * 2;
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
    void Update()
    {
        totalTime -= Time.deltaTime;
        if (totalTime <= 0)
        {
            if (score >= scoreGoal)
            {
                SceneManager.LoadScene("VictoryScreen");
            }
            else
            {
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }
}