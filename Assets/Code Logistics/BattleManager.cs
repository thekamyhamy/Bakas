using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public Transform dragonSpriteObject;
    private SpriteRenderer spriteRenderer;

    public Sprite playerSprite;
    public Sprite[] dragonSprites;
    public int[] dragonHPValues;

    private int currentDragonIndex;
    private int currentDragonHP;

    public float timer = 60f;

    public TMP_Text dragonHPText;
    public TMP_Text timerText;

    void Awake()
    {
        if (dragonSpriteObject == null)
            dragonSpriteObject = transform.Find("DragonSprite");

        spriteRenderer = dragonSpriteObject.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        currentDragonIndex = Manager.instance.currentDragon;

        spriteRenderer.sprite = dragonSprites[currentDragonIndex];
        currentDragonHP = dragonHPValues[currentDragonIndex];

        UpdateHPUI();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timerText != null)
            timerText.text = Mathf.CeilToInt(timer).ToString();

        if (timer <= 0)
            LoseBattle();
    }

    public void DamageDragon(int dmg)
    {
        currentDragonHP -= dmg;
        UpdateHPUI();

        if (currentDragonHP <= 0)
            WinBattle();
    }

    private void UpdateHPUI()
    {
        if (dragonHPText != null)
            dragonHPText.text = currentDragonHP.ToString();
    }

    private void WinBattle()
    {
        Manager.instance.WinDragon();
    }

    private void LoseBattle()
    {
        Manager.instance.LoseBattle();
    }
}
