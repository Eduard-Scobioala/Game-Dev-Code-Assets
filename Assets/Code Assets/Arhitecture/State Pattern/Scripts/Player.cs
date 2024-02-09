using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Dictionary<Type, IPlayerBehaviour> behaviourMap;
    public IPlayerBehaviour BehaviourCurrent { get; private set; }

    public delegate void PlayerBehaviourChange (Player sender, IPlayerBehaviour oldBehavior, IPlayerBehaviour newBehaviour);
    public event PlayerBehaviourChange BehaviourChanged;

    private void Start()
    {
        InitBehaviour();
        SetBehaviourByDefault();
    }

    private void InitBehaviour()
    {
        this.behaviourMap = new Dictionary<Type, IPlayerBehaviour>();

        behaviourMap[typeof(PlayerBehaviourIdle)] = new PlayerBehaviourIdle();
        behaviourMap[typeof(PlayerBehaviourActive)] = new PlayerBehaviourActive();
        behaviourMap[typeof(PlayerBehaviourAggressive)] = new PlayerBehaviourAggressive();
    }

    public void SetBehaviour(IPlayerBehaviour newBehaviour)
    {
        var oldBehaviour = this.BehaviourCurrent;

        this.BehaviourCurrent?.Exit();
        this.BehaviourCurrent = newBehaviour;
        this.BehaviourCurrent.Enter();

        BehaviourChanged?.Invoke(this, oldBehaviour, newBehaviour);
    }

    private void SetBehaviourByDefault()
    {
        SetBehaviourIdle();
    }

    private IPlayerBehaviour GetBehaviour<T>() where T : IPlayerBehaviour
    {
        var type = typeof(T);
        return this.behaviourMap[type];
    }

    private void Update()
    {
        this.BehaviourCurrent?.Update();
    }

    public void SetBehaviourIdle()
    {
        var behaviour = GetBehaviour<PlayerBehaviourIdle>();
        SetBehaviour(behaviour);
    }

    public void SetBehaviourActive()
    {
        var behaviour = GetBehaviour<PlayerBehaviourActive>();
        SetBehaviour(behaviour);
    }

    public void SetBehaviourAggressive()
    {
        var behaviour = GetBehaviour<PlayerBehaviourAggressive>();
        SetBehaviour(behaviour);
    }
}
