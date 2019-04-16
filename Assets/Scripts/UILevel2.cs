using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel2 : MonoBehaviour
{
    public GameObject Riddle1;
    public GameObject Riddle2;
    public GameObject Riddle3;
    public GameObject Riddle4;
    public GameObject SP1;
    public GameObject SP2;
    public GameObject SP3;

    // Start is called before the first frame update
    void Start()
    {
        Riddle1.SetActive(false);
        Riddle2.SetActive(false);
        Riddle3.SetActive(false);
        Riddle4.SetActive(false);
        SP1.SetActive(false);
        SP2.SetActive(false);
        SP3.SetActive(false);
    }

    public void HideRiddle1()
    {
        Riddle1.SetActive(false);
    }

    public void HideRiddle2()
    {
        Riddle2.SetActive(false);
    }

    public void HideRiddle3()
    {
        Riddle3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
