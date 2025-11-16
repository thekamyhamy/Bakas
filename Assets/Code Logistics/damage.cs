using UnityEngine;

public class DragonClick : MonoBehaviour
{
    public BattleManager manager;

    void OnMouseDown()
    {
        manager.DamageDragon(10); // or however much damage per click
    }
}