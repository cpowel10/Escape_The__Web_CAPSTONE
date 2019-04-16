using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPuzzle : MonoBehaviour
{
    public GameObject Puzzle;
    private bool PuzzleActive = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
            PuzzleActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player out of range");
            PuzzleActive = false;
            Puzzle.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && PuzzleActive)
        {
            if (Puzzle.activeInHierarchy)
            {
                
                Puzzle.SetActive(false);
            }
            else
            {
                Puzzle.SetActive(true);
            }
        }
    }
}
