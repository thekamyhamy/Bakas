using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [Header("Sprite Renderer")]
    public SpriteRenderer spriteRenderer;  

    [Header("Player Sprite")]
    public Sprite playerSprite;         

    [Header("Dragon Sprites")]
    public Sprite[] dragonSprites;          

    private int currentDragonIndex = 0;

    void Start()
    {

        if (dragonSprites.Length > 0)
        {
            currentDragonIndex = 0;
            spriteRenderer.sprite = dragonSprites[currentDragonIndex];
        }
        else
        {
            Debug.LogError("No dragon sprites assigned!");
        }
    }

    public void NextDragon()
    {
        if (dragonSprites.Length == 0) return;

        currentDragonIndex++;
        if (currentDragonIndex >= dragonSprites.Length)
            currentDragonIndex = 0;

        spriteRenderer.sprite = dragonSprites[currentDragonIndex];
    }
    public void ShowPlayer()
    {
        if (playerSprite != null)
            spriteRenderer.sprite = playerSprite;
        else
            Debug.LogError("Player sprite not assigned!");
    }
}
