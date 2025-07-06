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
    //Game Elements
    public static GameManager instance;
    public Animator eAnimator;
    //Environment
    public Camera cam;

    //Game Characters
    public Player player;
    public Enemy enemy;

    //Rigid Bodies
    public Rigidbody casing1;

    //Trackers
    public bool playerTurn = true;

    //Stats
    public int playerHealth;
    public int enemyHealth;

    //UI Elements
    //-Buttons
    public Button attackButton, defendButton, healButton, finisherButton;
    public GameObject attackButtonGO, defendButtonGO, healButtonGO, finisherButtonGO;
    public GameObject cylinderGO, bulletGO, casing1ButtonGO;
    public Button casing1Button;
    //-Gun Mode
    public Texture2D crosshair, hand;
    private Vector2 crosshairHotspot = new Vector2(16, 16);
    private Vector2 handHotspot = new Vector2(16, 0);



    //===========Start=============================================
    void Start()
    {
        GameManager.instance = this;
        cylinderGO.SetActive(false);
        bulletGO.SetActive(false);
        casing1ButtonGO.SetActive(false);
    }
    //===========Start=============================================

    //===========Update=============================================
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) 
        {
            fireRay();
        }
        
    }
    //===========Update=============================================

    public void fireRay() 
    { 
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(camRay, out RaycastHit hit)) 
        {
            Debug.Log("RAYCAST HIT!");
            if (hit.collider.tag == "Casings") 
            {
                Debug.Log("\tCASINGS HIT!");
                casing1.useGravity = true;
                casing1.AddForce(-2, 5, -1, ForceMode.Impulse);
            }
        }
    }
    
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
        cylinderGO.SetActive(true);
        bulletGO.SetActive(true);
        casing1ButtonGO.SetActive(true);
        Cursor.SetCursor(hand, handHotspot, CursorMode.Auto);
    }

}
