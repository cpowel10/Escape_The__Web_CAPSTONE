using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevel1 : MonoBehaviour
{
    //public GameObject PuzzleGridEasy;
    public GameObject SPPuzzle1;
    public GameObject NPC1;
    public GameObject PuzzleGridEasy;

    // Start is called before the first frame update
    void Start()
    {
        NPC1.SetActive(false);
        PuzzleGridEasy.SetActive(false);
    }

    public void ShowNPC1()
    {
        NPC1.SetActive(true);
    }

    public void HideNPC1()
    {
        NPC1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("space"))
        //{
       //     PuzzleGridEasy.SetActive(true);
        //}
    }
}
