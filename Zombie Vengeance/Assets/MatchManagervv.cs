using UnityEngine;

public class MatchManager : MonoBehaviour
{
    private BoardManager boardManager;

    void Start()
    {
        boardManager = FindObjectOfType<BoardManager>();
    }

    public void SwapTiles(Tile tileA, Tile tileB)
    {
        // Lógica para trocar as peças
        // Verificar combinações após a troca
    }

    private void CheckForMatches()
    {
        // Lógica para verificar combinações de 3 ou mais peças
    }
}
