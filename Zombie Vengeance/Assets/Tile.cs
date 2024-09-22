using UnityEngine;

public class Tile : MonoBehaviour
{
    private int xPos;
    private int yPos;

    public void SetPosition(int x, int y)
    {
        xPos = x;
        yPos = y;
    }

    public void OnMouseDown() // Para detectar cliques
    {
        // Lógica para selecionar a peça
    }
}
