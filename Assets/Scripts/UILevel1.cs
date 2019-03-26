using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevel1 : MonoBehaviour
{
    //public GameObject PuzzleGridEasy;
    public GameObject Signpost1;
    public GameObject SPPuzzle1;
    public Text SPText1;
    public GameObject NPC1;
    public Text NPCText1;
    public bool playerInRangeSign1;
    public GameObject PuzzleGridEasy;
    private bool triggerEntered = false;


    // Start is called before the first frame update
    void Start()
    {
        Signpost1.SetActive(false);
        NPC1.SetActive(false);
        PuzzleGridEasy.SetActive(false);
    }

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

    public void OnTriggerEnter()
    {
        triggerEntered = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && triggerEntered == true)
        {
            PuzzleGridEasy.SetActive(true);
        }
    }
}
