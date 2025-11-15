using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static Manager instance;
    public bool[] dragonDefeated = new bool[4];
    public int currentDragon;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }

    public void StartBattle(int dragonIndex)
    {
        currentDragon = dragonIndex;
        SceneManager.LoadScene("BattleScene");

    }
    public void WinDragon()
    {
        dragonDefeated[currentDragon] = true;
        bool alldone = true;
        foreach (bool d in dragonDefeated)
        {
            if (!d) alldone = false;
        }
        if (alldone)
        {
            SceneManager.LoadScene("WinScene");

        }
        else
        {
            SceneManager.LoadScene("MainWorld");

        }
    }

    public void LoseBattle()
    {
        SceneManager.LoadScene("LoseScene");

    }

}
