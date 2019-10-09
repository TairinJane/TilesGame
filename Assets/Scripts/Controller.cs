using System.Collections;
using System.Collections.Generic;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CheckTiles()
    {
        hitRay = Physics2D.RaycastAll(transform.position, Vector2.down, 6);
        tilesCount = 0;
        foreach (var tile in hitRay)
        {
            if (tile.transform.name.Contains(controllerType)) tilesCount++;
        }
        return tilesCount == 5;
    }
}
