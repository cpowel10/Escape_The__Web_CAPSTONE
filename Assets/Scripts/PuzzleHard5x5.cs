using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleHard5x5 : MonoBehaviour
{
    public Button button00;
    private bool On00;
    public Button button01;
    private bool On01;
    public Button button02;
    private bool On02;
    public Button button03;
    private bool On03;
    public Button button04;
    private bool On04;
    public Button button10;
    private bool On10;
    public Button button11;
    private bool On11;
    public Button button12;
    private bool On12;
    public Button button13;
    private bool On13;
    public Button button14;
    private bool On14;
    public Button button20;
    private bool On20;
    public Button button21;
    private bool On21;
    public Button button22;
    private bool On22;
    public Button button23;
    private bool On23;
    public Button button24;
    private bool On24;
    public Button button30;
    private bool On30;
    public Button button31;
    private bool On31;
    public Button button32;
    private bool On32;
    public Button button33;
    private bool On33;
    public Button button34;
    private bool On34;
    public Button button40;
    private bool On40;
    public Button button41;
    private bool On41;
    public Button button42;
    private bool On42;
    public Button button43;
    private bool On43;
    public Button button44;
    private bool On44;
    public Sprite off;
    public Sprite on;
    public GameObject door;
    public GameObject PuzzleGridHard;
    public Button close;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    public void openPuzzle()
    {
        PuzzleGridHard.SetActive(true);
    }

    public void closePuzzle()
    {
        PuzzleGridHard.SetActive(false);
    }

    public void closePuzzleAndOpenDoor()
    {
        PuzzleGridHard.SetActive(false);
        door.SetActive(false);
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
        On03 = !On03;
        On12 = !On12;
    }

    public void Button03OnClick()
    {
        On02 = !On02;
        On03 = !On03;
        On04 = !On04;
        On13 = !On13;
    }

    public void Button04OnClick()
    {
        On03 = !On03;
        On04 = !On04;
        On14 = !On14;
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
        On13 = !On13;
        On22 = !On22;
    }

    public void Button13OnClick()
    {
        On03 = !On03;
        On12 = !On12;
        On13 = !On13;
        On14 = !On14;
        On23 = !On23;
    }

    public void Button14OnClick()
    {
        On04 = !On04;
        On13 = !On13;
        On14 = !On14;
        On24 = !On24;
    }

    public void Button20OnClick()
    {
        On10 = !On10;
        On20 = !On20;
        On21 = !On21;
        On30 = !On30;
    }

    public void Button21OnClick()
    {
        On11 = !On11;
        On20 = !On20;
        On21 = !On21;
        On22 = !On22;
        On31 = !On31;
    }

    public void Button22OnClick()
    {
        On12 = !On12;
        On21 = !On21;
        On22 = !On22;
        On23 = !On23;
        On32 = !On32;
    }

    public void Button23OnClick()
    {
        On13 = !On13;
        On22 = !On22;
        On23 = !On23;
        On24 = !On24;
        On33 = !On33;
    }

    public void Button24OnClick()
    {
        On14 = !On14;
        On23 = !On23;
        On24 = !On24;
        On34 = !On34;
    }

    public void Button30OnClick()
    {
        On20 = !On20;
        On30 = !On30;
        On31 = !On31;
        On40 = !On40;
    }

    public void Button31OnClick()
    {
        On21 = !On21;
        On30 = !On30;
        On31 = !On31;
        On32 = !On32;
        On41 = !On41;
    }

    public void Button32OnClick()
    {
        On22 = !On22;
        On31 = !On31;
        On32 = !On32;
        On33 = !On33;
        On42 = !On42;
    }

    public void Button33OnClick()
    {
        On23 = !On23;
        On32 = !On32;
        On33 = !On33;
        On34 = !On34;
        On43 = !On43;
    }

    public void Button34OnClick()
    {
        On24 = !On24;
        On33 = !On33;
        On34 = !On34;
        On44 = !On44;
    }

    public void Button40OnClick()
    {
        On30 = !On30;
        On40 = !On40;
        On41 = !On41;
    }

    public void Button41OnClick()
    {
        On31 = !On31;
        On40 = !On40;
        On41 = !On41;
        On42 = !On42;
    }

    public void Button42OnClick()
    {
        On32 = !On32;
        On41 = !On41;
        On42 = !On42;
        On43 = !On43;
    }

    public void Button43OnClick()
    {
        On33 = !On33;
        On42 = !On42;
        On43 = !On43;
        On44 = !On44;
    }

    public void Button44OnClick()
    {
        On34 = !On34;
        On43 = !On43;
        On44 = !On44;
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

        if (On03)
        {
            button03.image.sprite = on;
        }
        else
        {
            button03.image.sprite = off;
        }

        if (On04)
        {
            button04.image.sprite = on;
        }
        else
        {
            button04.image.sprite = off;
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

        if (On13)
        {
            button13.image.sprite = on;
        }
        else
        {
            button13.image.sprite = off;
        }

        if (On14)
        {
            button14.image.sprite = on;
        }
        else
        {
            button14.image.sprite = off;
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

        if (On23)
        {
            button23.image.sprite = on;
        }
        else
        {
            button23.image.sprite = off;
        }

        if (On24)
        {
            button24.image.sprite = on;
        }
        else
        {
            button24.image.sprite = off;
        }


        if (On30)
        {
            button30.image.sprite = on;
        }
        else
        {
            button30.image.sprite = off;
        }

        if (On30)
        {
            button30.image.sprite = on;
        }
        else
        {
            button30.image.sprite = off;
        }

        if (On31)
        {
            button31.image.sprite = on;
        }
        else
        {
            button31.image.sprite = off;
        }

        if (On32)
        {
            button32.image.sprite = on;
        }
        else
        {
            button32.image.sprite = off;
        }

        if (On33)
        {
            button33.image.sprite = on;
        }
        else
        {
            button33.image.sprite = off;
        }

        if (On34)
        {
            button34.image.sprite = on;
        }
        else
        {
            button34.image.sprite = off;
        }

        if (On40)
        {
            button40.image.sprite = on;
        }
        else
        {
            button40.image.sprite = off;
        }

        if (On41)
        {
            button41.image.sprite = on;
        }
        else
        {
            button41.image.sprite = off;
        }

        if (On42)
        {
            button42.image.sprite = on;
        }
        else
        {
            button42.image.sprite = off;
        }

        if (On43)
        {
            button43.image.sprite = on;
        }
        else
        {
            button43.image.sprite = off;
        }

        if (On44)
        {
            button44.image.sprite = on;
        }
        else
        {
            button44.image.sprite = off;
        }

        if (On00 && On01 && On02 && On03 && On04 && On10 &&
            On11 && On12 && On13 && On14 && On20 && On21 && On22 && On23 && On24 &&
            On30 && On31 && On32 && On33 && On34 && 
            On40 && On41 && On42 && On43 && On44)
        {
            //Done
            door.SetActive(false);
            PuzzleGridHard.SetActive(false);
        }
    }
}
