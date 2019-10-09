using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public GameObject restartButton;
    public GameObject winPanel;

    public void ShowWinUI()
    {
        winPanel.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void HideUI()
    {
        winPanel.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    void OnClick()
    {
        Debug.Log("ButtonClick");
        HideUI();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    void Start()
    {
        gm = this;
        restartButton.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
