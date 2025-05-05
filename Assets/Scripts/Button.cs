using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackButton : MonoBehaviour
{
    public GameManager Manager;
    public void Attack()
    {
        Debug.Log("Attacked!");
        Manager.playerAttacks();
    }
}
