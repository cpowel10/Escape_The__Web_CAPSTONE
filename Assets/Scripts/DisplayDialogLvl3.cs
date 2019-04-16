using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDialogLvl3 : MonoBehaviour
{

    public GameObject Signpost;
    public Text SPText;
    public string dialog;
    private bool SPActive = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
            SPActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player out of range");
            SPActive = false;
            Signpost.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && SPActive)
        {
            if (Signpost.activeInHierarchy)
            {
                Signpost.SetActive(false);
            }
            else
            {
                Signpost.SetActive(true);
                SPText.text = dialog;
            }
        }
    }
}
