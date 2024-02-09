using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourAggressive : IPlayerBehaviour
{
    public void Enter()
    {
        Debug.Log("Enter AGGRESSIVE state");
    }

    public void Exit()
    {
        Debug.Log("Exit AGGRESSIVE state");
    }

    public void Update()
    {
        Debug.Log("Update AGGRESSIVE state");
    }
}
