using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleEasy1 : MonoBehaviour
{
    public Button button00;
    private bool On00;
    public Button button01;
    private bool On01;
    public Button button02;
    private bool On02;
    public Button button10;
    private bool On10;
    public Button button11;
    private bool On11;
    public Button button12;
    private bool On12;
    public Button button20;
    private bool On20;
    public Button button21;
    private bool On21;
    public Button button22;
    private bool On22;
    public Sprite off;
    public Sprite on;
    public GameObject door;
    public GameObject doorHard;
    public GameObject PuzzleGridEasy;
    public Button close;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        doorHard.SetActive(true);
    }

    public void openPuzzle()
    {
        if (Input.GetKeyDown("C"))
            PuzzleGridEasy.SetActive(true);
    }

    public void closePuzzle()
    {
        PuzzleGridEasy.SetActive(false);
    }

    public void Button00OnClick()
    {
        On00 = !On00;
        On01 = !On01;
        On10 = !On10;
    }

    public void Button01OnClick()
    {
        On00 = !On00;
        On01 = !On01;
        On02 = !On02;
        On11 = !On11;
    }

     public void Button02OnClick()
    {
        On01 = !On01;
        On02 = !On02;
        On12 = !On12;
    }

     public void Button10OnClick()
    {
        On00 = !On00;
        On10 = !On10;
        On11 = !On11;
        On20 = !On20;
    }

     public void Button11OnClick()
    {
        On01 = !On01;
        On10 = !On10;
        On11 = !On11;
        On12 = !On12;
        On21 = !On21;

    }

     public void Button12OnClick()
    {
        On02 = !On02;
        On11 = !On11;
        On12 = !On12;
        On22 = !On22;
    }

    public void Button20OnClick()
    {
        On10 = !On10;
        On20 = !On20;
        On21 = !On21;
    }

     public void Button21OnClick()
    {
        On11 = !On11;
        On20 = !On20;
        On21 = !On21;
        On22 = !On22;
    }

     public void Button22OnClick()
    {
        On12 = !On12;
        On21 = !On21;
        On22 = !On22;
    }

    // Update is called once per frame
    void Update()
    {
        if (On00)
        {
            button00.image.sprite = on;
        }
        else
        {
            button00.image.sprite = off;
        }

        if (On01)
        {
            button01.image.sprite = on;
        }
        else
        {
            button01.image.sprite = off;
        }

        if (On02)
        {
            button02.image.sprite = on;
        }
        else
        {
            button02.image.sprite = off;
        }

        if (On10)
        {
            button10.image.sprite = on;
        }
        else
        {
            button10.image.sprite = off;
        }

        if (On11)
        {
            button11.image.sprite = on;
        }
        else
        {
            button11.image.sprite = off;
        }

        if (On12)
        {
            button12.image.sprite = on;
        }
        else
        {
            button12.image.sprite = off;
        }

        if (On20)
        {
            button20.image.sprite = on;
        }
        else
        {
            button20.image.sprite = off;
        }

        if (On21)
        {
            button21.image.sprite = on;
        }
        else
        {
            button21.image.sprite = off;
        }

        if (On22)
        {
            button22.image.sprite = on;
        }
        else
        {
            button22.image.sprite = off;
        }

        if (On00 && On01 && On02 && On10 && 
            On11 && On12 && On20 && On21 && On22)
        {
            //Done
            door.SetActive(false);
            doorHard.SetActive(false);
            PuzzleGridEasy.SetActive(false);
        }
    }
}
