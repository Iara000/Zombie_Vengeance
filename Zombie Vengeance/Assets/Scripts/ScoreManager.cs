using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score;
    public TextMeshProUGUI scoreText;
    public int scoreGoal;
    public float totalTime;
    public float attackTime;
    public Animator Girl;
    public Animator Zombie;
    public string girl;
    public string zombie;
    private int nextSceneLoad;
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
        if (Girl != null)
        {
            Girl.SetTrigger(girl);
        }
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
        attackTime -= Time.deltaTime;
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
        if (attackTime <= 0)
        {
            if (Zombie != null)
            {
                Zombie.SetTrigger(zombie);
            }
        }
    }
}