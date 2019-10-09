using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private GameObject blueController, greenController, yellowController;
    
    // Start is called before the first frame update
    void Start()
    {
        blueController = transform.GetChild(0).gameObject;
        Debug.Log(blueController.name);
        greenController = transform.GetChild(1).gameObject;
        Debug.Log(greenController.name);
        yellowController = transform.GetChild(2).gameObject;
        Debug.Log(yellowController.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
