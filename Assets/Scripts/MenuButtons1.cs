using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons1 : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject TextPanel1;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        TextPanel1.SetActive(false);
    }

    public void showTextPanel1()
    {
        TextPanel1.SetActive(true);
    }

    public void hideTextPanel1()
    {
        TextPanel1.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void showMainPanel()
    {
        MenuPanel.SetActive(true);
        TextPanel1.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
