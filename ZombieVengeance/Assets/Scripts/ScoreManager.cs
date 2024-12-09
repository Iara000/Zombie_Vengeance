using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [Header("Timer Settings")]
    [SerializeField] private float startTime = 120f;
    private float currentTime;
    private bool isTimerRunning = true;
    [SerializeField] private TextMeshProUGUI timerText;
    [Header("Score Settings")]
    private int score = 0;
    [SerializeField] private int scoreGoal = 100;
    [SerializeField] private TextMeshProUGUI scoreText;
    [Header("Scene Management")]
    [SerializeField] private string victoryScene = "VictoryScreen";
    [SerializeField] private string loseScene = "LoseScreen";
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        currentTime = startTime;
        UpdateTimerDisplay();
        UpdateScoreText();
    }
    private void Update()
    {
        HandleTimer();
        CheckWinCondition();
    }
    public void AddScore(int matchCount)
    {
        int points = matchCount * 2;
        score += points;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = $"Score: {score}";
    }
    private void HandleTimer()
    {
        if (!isTimerRunning) return;
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
            isTimerRunning = false;
            OnTimerEnd();
        }
        UpdateTimerDisplay();
    }
    private void UpdateTimerDisplay()
    {
        if (timerText == null) return;

        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
    private void CheckWinCondition()
    {
        if (score >= scoreGoal)
        {
            LoadScene(victoryScene);
        }
        else if (!isTimerRunning && score < scoreGoal)
        {
            LoadScene(loseScene);
        }
    }
    private void OnTimerEnd()
    {
        // Você pode adicionar lógica adicional aqui, se necessário.
        isTimerRunning = false;
    }
    private void LoadScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
            SceneManager.LoadScene(sceneName);
    }
}
