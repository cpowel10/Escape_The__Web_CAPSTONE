using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevel1 : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject NPC4;
    public GameObject NPC5;
    public GameObject SP1;
    public GameObject SP2;
    public GameObject PuzzleGridEasy;
    public GameObject PuzzleGridHard;

    // Start is called before the first frame update
    void Start()
    {
        NPC1.SetActive(false);
        NPC2.SetActive(false);
        NPC3.SetActive(false);
        NPC4.SetActive(false);
        NPC5.SetActive(false);
        SP1.SetActive(false);
        SP2.SetActive(false);
        PuzzleGridEasy.SetActive(false);
        PuzzleGridHard.SetActive(false);
    }

    public void ShowSP1()
    {
        SP1.SetActive(true);
    }

    public void ShowSP2()
    {
        SP2.SetActive(true);
    }

    public void ShowNPC1()
    {
        NPC1.SetActive(true);
    }

    public void ShowNPC2()
    {
        NPC2.SetActive(true);
    }

    public void ShowNPC3()
    {
        NPC3.SetActive(true);
    }

    public void ShowNPC4()
    {
        NPC4.SetActive(true);
    }

    public void ShowNPC5()
    {
        NPC5.SetActive(true);
    }

    public void HideSP1()
    {
        SP1.SetActive(false);
    }

    public void HideSP2()
    {
        SP2.SetActive(false);
    }

    public void HideNPC1()
    {
        NPC1.SetActive(false);
    }

    public void HideNPC2()
    {
        NPC2.SetActive(false);
    }

    public void HideNPC3()
    {
        NPC3.SetActive(false);
    }

    public void HideNPC4()
    {
        NPC4.SetActive(false);
    }

    public void HideNPC5()
    {
        NPC5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
