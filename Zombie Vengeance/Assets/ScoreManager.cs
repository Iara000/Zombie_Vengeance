using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public void AddScore(int points)
    {
        score += points;
        // Atualizar UI
    }

    public int GetScore()
    {
        return score;
    }
}
