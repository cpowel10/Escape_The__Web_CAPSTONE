using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleScript2 : MonoBehaviour
{
    public GameObject door;
    public GameObject Riddle;
    public InputField input1;
    public InputField input2;
    public string answer1;
    public string answer2;
    private string err = "Incorrect";
    private string pass = "Correct!!";
    public Text error1;
    public Text error2;
    public Button close;
    private bool correct1 = false;
    private bool correct2 = false;

    public void Text_Changed1(string newText)
    {
        if (newText == answer1)
        {
            error1.text = pass;
            correct1 = true;
        }
        else
        {
            error1.text = err;
            correct1 = false;
        }
    }

    public void Text_Changed2(string newText)
    {
        if (newText == answer2)
        {
            error2.text = pass;
            correct2 = true;
        }
        else
        {
            error2.text = err;
            correct2 = false;
        }
    }

    void Update()
    {
        if (correct1 && correct2)
        {
            door.SetActive(false);
        }
    }

    public void CloseRiddle()
    {
        Riddle.SetActive(false);
    }
}
