using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour
{
    public int playerCount;
    public GameObject[] players;
    public Transform[] spawnLocation;
    GameObject Player1;
    GameObject Player2;
    GameObject Player3;

    // Use this for initialization
    void Start()
    {
        playerCount = PlayerSelect.playerCount;
        switch (playerCount)
        {
            case 1:
                Player1 = Instantiate(players[0], spawnLocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                break;
            case 2:
                Player1 = Instantiate(players[0], spawnLocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                Player2 = Instantiate(players[1], spawnLocation[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                break;
            case 3:
                Player1 = Instantiate(players[0], spawnLocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                Player2 = Instantiate(players[1], spawnLocation[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                Player3 = Instantiate(players[2], spawnLocation[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
