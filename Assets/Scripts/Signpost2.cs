using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signpost2 : MonoBehaviour
{
    public GameObject Signpost;
    public Text SP2Text;
    public string SP2dialogue;
    private bool SP2dialogueActive = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
            SP2dialogueActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player out of range");
            SP2dialogueActive = false;
            Signpost.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && SP2dialogueActive)
        {
            if (Signpost.activeInHierarchy)
            {
                Signpost.SetActive(false);
            }
            else
            {
                Signpost.SetActive(true);
                SP2Text.text = SP2dialogue;
            }
        }
    }
}
