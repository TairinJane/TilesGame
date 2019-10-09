using UnityEngine;

public class Controller : MonoBehaviour
{
    private RaycastHit2D[] hitRay;
    private string controllerType;

    private int tilesCount;

    // Start is called before the first frame update
    void Start()
    {
        tilesCount = 0;
        controllerType = name.Replace("Controller", "");
        // hitRay = new RaycastHit2D[6];
    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool CheckTiles()
    {
        tilesCount = 0;
        hitRay = Physics2D.RaycastAll(transform.position, Vector2.down, 6);
        foreach (var tile in hitRay)
        {
            if (tile.collider && tile.transform.name.Contains(controllerType)) tilesCount++;
        }

        Debug.Log(controllerType + " Tiles Count: " + tilesCount);
        return tilesCount == 5;
    }
}