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
    public Text error;

    public void Text_Changed(string newText)
    {
        if(newText == answer)
        {
            door.SetActive(false);
            Riddle.SetActive(false);
        }
        else
        {
            error.text = "Incorrect";
        }
    }
}
