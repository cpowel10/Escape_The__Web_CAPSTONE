﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDialog : MonoBehaviour
{
    public GameObject Signpost1;
    public Text SP1Text;
    public string SP1dialogue;
    private bool SP1dialogueActive = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SP1dialogueActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player out of range");
            SP1dialogueActive = false;
            Signpost1.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && SP1dialogueActive)
        {
            if (Signpost1.activeInHierarchy)
            {
                Signpost1.SetActive(false);
            }
            else
            {
                Signpost1.SetActive(true);
                SP1Text.text = SP1dialogue;
            }
        }
    }
}
