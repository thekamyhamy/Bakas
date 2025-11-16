using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleManager : MonoBehaviour
{
    public int[] dragonHPValues = { 20, 30, 40, 50 };
    private int currentHP;
    private float timer = 10f;
    public Text hpText;
    public Text timerText;
    public Image dragonImage;
    public Image playerImage;
    public Sprite[] dragonSprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int dragon = Manager.instance.currentDragon;
        currentHP = dragonHPValues[dragon];

        hpText.text = "Hp: " + currentHP;

        // Set battle sprite
        dragonImage.sprite = dragonSprites[dragon];
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(timer);
        if (timer <= 0)
        {
            Manager.instance.LoseBattle();

        }
    }

    public void OnDragonClick()
    {
        currentHP--;
        hpText.text = "Hp: " + currentHP;
        if (currentHP <= 0)
        {
            Manager.instance.WinDragon();

        }
    }
}
