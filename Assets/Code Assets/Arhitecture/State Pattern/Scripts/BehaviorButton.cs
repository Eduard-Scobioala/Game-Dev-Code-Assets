using UnityEngine;

public class BehaviorButton : MonoBehaviour
{
    [SerializeField] private Player player;

    public void OnIdleButtonPressed()
    {
        player.SetBehaviourIdle();
    }

    public void OnActiveButtonPressed()
    {
        player.SetBehaviourActive();
    }

    public void OnAggressiveButtonPressed()
    {
        player.SetBehaviourAggressive();
    }
}
