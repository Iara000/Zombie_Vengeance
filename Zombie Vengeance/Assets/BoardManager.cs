using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject[] tilePrefabs; // Prefabs das peças
    public int width = 8;
    public int height = 8;
    private Tile[,] tiles;

    void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameObject tileObject = Instantiate(tilePrefabs[Random.Range(0, tilePrefabs.Length)], new Vector3(x, y, 0), Quaternion.identity);
                Tile tile = tileObject.GetComponent<Tile>();
                tiles[x, y] = tile;
                tile.SetPosition(x, y);
            }
        }
    }
}
