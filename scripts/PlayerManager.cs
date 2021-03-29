using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status  {get; private set;}

    private int playerHealth {get; set;} // just a test data you can setup

    public void Startup()
    {
        Debug.Log("PlayerManager started");

        status = ManagerStatus.Started;
        playerHealth = 77;

        
    }

    public void ChangeHealth(int deltaHP) // test public function to change player HP
    {
        playerHealth += deltaHP;
    }
}
