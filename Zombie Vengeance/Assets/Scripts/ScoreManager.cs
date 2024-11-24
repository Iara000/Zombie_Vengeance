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
        if(score >= scoreGoal)
        {
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                SceneManager.LoadScene("VictoryScreen");
            }
            else
            {
                score = 0;
                SceneManager.LoadScene(nextSceneLoad);
                if (nextSceneLoad > PlayerPrefs.GetInt("LevelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }

        }
    }
}