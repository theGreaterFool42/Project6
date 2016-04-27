using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject World;
    public GameObject MainCamera;
    Vector3 center;
    float longD;
    float midD;
    float shortD;
    // Use this for initialization
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        Player3 = GameObject.FindGameObjectWithTag("Player3");
        World = GameObject.FindGameObjectWithTag("World");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player2 != null) && (Player3 != null))
        {
            Debug.DrawLine(Player1.transform.position, Player2.transform.position, Color.red);
            Debug.DrawLine(Player1.transform.position, Player3.transform.position, Color.blue);
            Debug.DrawLine(Player2.transform.position, Player3.transform.position, Color.green);
            Debug.DrawLine(transform.position, Player1.transform.position, Color.magenta);
            Debug.DrawLine(transform.position, Player2.transform.position, Color.magenta);
            Debug.DrawLine(transform.position, Player3.transform.position, Color.magenta);
            Debug.DrawLine(transform.position, World.transform.position, Color.yellow);
            Debug.DrawLine(transform.position, MainCamera.transform.position, Color.cyan);
            
            
            float distance1 = Vector3.Distance(Player1.transform.position, Player2.transform.position);
            float distance2 = Vector3.Distance(Player1.transform.position, Player3.transform.position);
            float distance3 = Vector3.Distance(Player2.transform.position, Player3.transform.position);
            
            center = (Player1.transform.position + Player2.transform.position + Player3.transform.position) / 3;
            
            transform.position = center;
            if ((distance1 < distance2) && (distance1 < distance3))
            {
                shortD = distance1;
                if (distance2 < distance3)
                {
                    midD = distance2;
                    longD = distance3;
                }
                else
                {
                    midD = distance3;
                    longD = distance2;
                }
            }
            else if ((distance2 < distance1) && (distance2 < distance3))
            {
                shortD = distance2;
                if (distance1 < distance3)
                {
                    midD = distance1;
                    longD = distance3;
                }
                else
                {
                    midD = distance3;
                    longD = distance1;
                }
            }
            else if ((distance3 < distance1) && (distance3 < distance2))
            {
                shortD = distance3;
                if (distance1 < distance2)
                {
                    midD = distance1;
                    longD = distance2;
                }
                else
                {
                    midD = distance2;
                    longD = distance1;
                }
            }
            else
            {
                print("Wrong Distance calculation! Please check CameraController!");
            }
        }
        
            print("LongD:  " + longD);
            print("MidD:   " + midD);
            print("ShortD: " + shortD);

            if (longD < 90)
            {
                MainCamera.transform.LookAt(center);
                MainCamera.transform.position = center * 2; 
            }
    }
}
