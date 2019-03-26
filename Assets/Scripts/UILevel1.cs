using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel1 : MonoBehaviour
{
    //public GameObject PuzzleGridEasy;
    public GameObject Signpost1;
    public GameObject NPC1;
    public bool playerInRangeSign1;

    // Start is called before the first frame update
    void Start()
    {
        //PuzzleGridEasy.SetActive(false);
        Signpost1.SetActive(false);
        NPC1.SetActive(false);
    }

    //public void ShowPuzzleGridEasy()
    //{
    //   PuzzleGridEasy.SetActive(true);
    //}

    //public void HidePuzzleGridEasy()
    //{
    //    PuzzleGridEasy.SetActive(false);
    //}

    public void ShowSignPost1(Collider2D other)
    {
        //Signpost1.SetActive(true);
        if (other.CompareTag("Player"))
        {
            playerInRangeSign1 = true;
            //Debug.Log("Player in range");
        }
    }

    public void HideSignPost1(Collider2D other)
    {
        //Signpost1.SetActive(false);
        if (other.CompareTag("Player"))
        {
            playerInRangeSign1 = false;
            //Debug.Log("Player left range");
        }
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
        
    }
}
