using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleScript : MonoBehaviour
{
    public GameObject door;
    public GameObject Riddle;
    public InputField input;
    public string answer;
    private string err = "Incorrect";
    public string pass;
    public Text error;
    public Button close;

    public void Text_Changed(string newText)
    {
        if(newText == answer)
        {
            door.SetActive(false);
            error.text = pass;
        }
        else
        {
            error.text = err;
        }
    }

    public void CloseRiddle()
    {
        Riddle.SetActive(false);
    }
}
