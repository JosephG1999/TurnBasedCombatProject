using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager Manager;
    void Start()
    {
        Manager.playerHealth = 150;
    }

    void Update()
    {
        
    }
}
