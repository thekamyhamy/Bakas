using UnityEditor.Build.Content;
using UnityEngine;


public class StartingBattle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int dragonIndex;
    private void OnMouseDown()
    {
        Manager.instance.StartBattle(dragonIndex);

    }
}
