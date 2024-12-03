using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private float startTime;
    private float currentTime;
    private bool timerRunning = true;
    [SerializeField] private TextMeshProUGUI timerText;
    void Start()
    {
        currentTime = startTime;
        UpdateTimerDisplay();
    }
    void Update()
    {
        if (timerRunning)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime = 0;
                timerRunning = false;
            }
            UpdateTimerDisplay();
        }
    }
    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
}