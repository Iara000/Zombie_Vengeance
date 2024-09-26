using UnityEngine;

public class MatchManager : MonoBehaviour
{
    private BoardManager boardManager;
    private Tile selectedTile;

    void Start()
    {
        boardManager = FindObjectOfType<BoardManager>();
    }

    public void SelectedTile(Tile tile)
    {
        if (selectedTile == null)
        {
            selectedTile = tile; // Guarda a peça selecionada
        }
        else
        {
            SwapTiles(selectedTile, tile);
            selectedTile = null; // Reseta a seleção
        }
    }

    public void DeselectedTile(Tile tile)
    {
        // Você pode adicionar lógica aqui se quiser
    }

    public void SwapTiles(Tile tileA, Tile tileB)
    {
        // Troca as posições (pode incluir animações)
        Vector3 tempPosition = tileA.transform.position;
        tileA.transform.position = tileB.transform.position;
        tileB.transform.position = tempPosition;

        // Verificar combinações após a troca
        CheckForMatches();
    }

    private void CheckForMatches()
    {
        // Lógica para verificar combinações de 3 ou mais peças
    }
}
