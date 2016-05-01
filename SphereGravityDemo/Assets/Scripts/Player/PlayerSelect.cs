using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
    public static int playerCount = 3;
    public string mainLevel;
    
    // Use this for initialization
    void Start()
    {
        mainLevel = "MainScene";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerSelection(int pCount)
    {
        playerCount = pCount;

        print(playerCount);
        SceneManager.LoadScene(mainLevel);
    }
}
