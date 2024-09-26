using UnityEngine;
using UnityEngine.UI; // Não esqueça de adicionar esta linha

public class ScoreManager : MonoBehaviour
{
    private int score;
    public Text scoreText; // Referência ao componente de texto

    void Start()
    {
        UpdateScoreText(); // Atualiza o texto inicial
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText(); // Atualiza o texto sempre que a pontuação muda
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // Atualiza o texto
    }

    public int GetScore()
    {
        return score;
    }
}
