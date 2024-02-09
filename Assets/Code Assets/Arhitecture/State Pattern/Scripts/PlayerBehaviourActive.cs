using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourActive : IPlayerBehaviour
{
    public void Enter()
    {
        Debug.Log("Enter ACTIVE state");
    }

    public void Exit()
    {
        Debug.Log("Exit ACTIVE state");
    }

    public void Update()
    {
        Debug.Log("Update ACTIVE state");
    }
}
