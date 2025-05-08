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

    public Player player;
    public Enemy enemy;
    public bool playerTurn = true;
    public bool hit;

    public int playerHealth;
    public int enemyHealth;
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
            hit = true;
        }
        playerTurn = false;
        hit = false;
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
