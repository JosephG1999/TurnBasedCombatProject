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
    public Animator eAnimator;

    //Game Characters
    public Player player;
    public Enemy enemy;

    //Trackers
    public bool playerTurn = true;

    //Stats
    public int playerHealth;
    public int enemyHealth;

    //UI Elements
    //-Buttons
    public Button attackButton, defendButton, healButton, finisherButton;
    public GameObject attackButtonGO, defendButtonGO, healButtonGO, finisherButtonGO;
    //-Gun Mode
    public Texture2D crosshair, hand;
    private Vector2 crosshairHotspot = new Vector2(16, 16);
    private Vector2 handHotspot = new Vector2(16, 0);



    //===========Start=============================================
    void Start()
    {
        GameManager.instance = this;
    }
    //===========Start=============================================

    //===========Update=============================================
    void Update()
    {
        
    }
    //===========Update=============================================

    public void gun()
    {
        reloadMode();
        //shootMode();
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

    public void shootMode() 
    {
        Debug.Log("SHOOT MODE!");
        Cursor.SetCursor(crosshair, crosshairHotspot, CursorMode.Auto);
    }

    public void reloadMode() 
    {
        Debug.Log("RELOAD MODE!");
        attackButtonGO.SetActive(false);
        defendButtonGO.SetActive(false);
        healButtonGO.SetActive(false);
        finisherButtonGO.SetActive(false);
        Cursor.SetCursor(hand, handHotspot, CursorMode.Auto);
    }

}
