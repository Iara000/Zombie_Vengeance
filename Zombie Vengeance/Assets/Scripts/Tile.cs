using UnityEngine;

public class Tile : MonoBehaviour
{
    private int xPos;
    private int yPos;
    private MatchManager matchManager;
    private bool isSelected = false;

    private void Start()
    {
        matchManager = FindObjectOfType<MatchManager>();
    }

    public void SetPosition(int x, int y)
    {
        xPos = x;
        yPos = y;
    }

    public void OnMouseDown()
    {
        if (!isSelected)
        {
            SelectTile();
        }
        else
        {
            DeselectTile();
        }
    }

    private void SelectTile()
    {
        isSelected = true;
        // Adicione uma mudança visual para indicar que a peça está selecionada
        matchManager.SelectedTile(this);
    }

    private void DeselectTile()
    {
        isSelected = false;
        // Remova a mudança visual
        matchManager.DeselectedTile(this);
    }

    public int GetXPos() => xPos;
    public int GetYPos() => yPos;
}
