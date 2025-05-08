using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager Manager;
    void Start()
    {
        Manager.enemyHealth = 200;
    }

    
    void Update()
    {
        //enemy attacks if the player already took their turn
        if (Manager.playerTurn == false) 
        {
            Debug.Log("Enemy Turn!!!");
            Manager.playerHealth -= 45;
            Manager.playerTurn = true;
        } 
    }
}
