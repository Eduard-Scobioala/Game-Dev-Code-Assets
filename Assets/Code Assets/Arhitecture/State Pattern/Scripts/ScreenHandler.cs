using TMPro;
using UnityEngine;

public class ScreenHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI previousStateText;
    [SerializeField] private TextMeshProUGUI currentStateText;

    [SerializeField] private Player player;

    private void Start()
    {
        player.BehaviourChanged += (_, oldBehaviour, newBehaviour) => SetText(oldBehaviour, newBehaviour);

        SetText(null, player.BehaviourCurrent);
    }

    private void SetText(IPlayerBehaviour oldBehaviour, IPlayerBehaviour newBehaviour)
    {
        previousStateText.text = oldBehaviour?.GetType()?.Name ?? "None";
        currentStateText.text = newBehaviour?.GetType()?.Name ?? "None";
    }
}
