using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEditor.Experimental.GraphView;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Player player;
    public Player enemy;

    public int playerHealth = 100;
    public int enemyHealth = 100;
    public AttackButton attackButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void playerHit()
    {

    }
    public void playerAttacks()
    {
        enemyHealth -= 10;
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
