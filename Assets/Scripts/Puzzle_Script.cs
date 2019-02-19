using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Script : MonoBehaviour
{
    public GameObject PuzzleGridEasy;

    // Start is called before the first frame update
    void Start()
    {
        PuzzleGridEasy.SetActive(false);
    }

    public void showPuzzleGridEasy()
    {
        PuzzleGridEasy.SetActive(true);
    }

    public void hidePuzzleGridEasy()
    {
        PuzzleGridEasy.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
