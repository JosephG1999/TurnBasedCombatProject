using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Button : MonoBehaviour
{
    public GameManager Manager;
    public void Attack()
    {
        Debug.Log("Attacked!");
        Manager.playerAttacks();
    }

    public void Defend() 
    {
        Debug.Log("Defended!");
        Manager.playerDefends();
    }
    public void Heal()
    {
        Debug.Log("Healed!");
        Manager.playerHeals();
    }
    public void Finisher()
    {
        Debug.Log("Finishing Move!");
        Manager.playerFinisher();
    }
}
