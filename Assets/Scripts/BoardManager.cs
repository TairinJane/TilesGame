using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public Controller blueController, greenController, yellowController;
    private Tile[] tilesList;

    // Start is called before the first frame update
    void Start()
    {
        tilesList = FindObjectsOfType<Tile>();
        GameManager.gm.HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (blueController.CheckTiles() && greenController.CheckTiles() && yellowController.CheckTiles())
        {
            GameManager.gm.ShowWinUI();
            foreach (var tile in tilesList)
            {
                tile.Deactivate();
            }
        }
    }
}
