using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourIdle : IPlayerBehaviour
{
    public void Enter()
    {
        Debug.Log("Enter IDLE state");
    }

    public void Exit()
    {
        Debug.Log("Exit IDLE state");
    }

    public void Update()
    {
        Debug.Log("Update IDLE state");
    }
}
