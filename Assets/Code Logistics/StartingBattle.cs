using UnityEngine;

public class StartingBattle : MonoBehaviour
{
    public int dragonIndex;

    private void OnMouseUpAsButton()
    {
        Manager.instance.StartBattle(dragonIndex);
    }
}