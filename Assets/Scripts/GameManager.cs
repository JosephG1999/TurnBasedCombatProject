using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEditor.Experimental.GraphView;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //Game Characters
    public Player player;
    public Enemy enemy;

    //Trackers
    public bool playerTurn = true;

    //Stats
    public int playerHealth;
    public int enemyHealth;

    //Buttons
    public Button attackButton, defendButton, healButton, finisherButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void playerHit()
    {

    }
    public void playerAttacks()
    {
        if (UnityEngine.Random.value <= 0.5)
        {
            enemyHealth -= 10;
        }
        playerTurn = false;
    }

    public void playerDefends()
    {
        playerTurn = false;
    }
    public void playerHeals()
    {
        playerHealth += 10;
        playerTurn = false;
    }
    public void playerFinisher()
    {
        enemyHealth -= 100;
        playerTurn = false;
    }

    void Start()
    {
        GameManager.instance = this;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
