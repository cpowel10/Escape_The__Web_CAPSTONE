﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;
    public int currentHealth;
    public string hp;

    bool isDead;
    bool isDamaged;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        hp = (currentHealth + " / " + startingHealth).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDamaged)
        {

        }
    }
}