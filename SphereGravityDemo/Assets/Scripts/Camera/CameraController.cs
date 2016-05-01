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
    float distance1;
    float distance2;
    float distance3;
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
        Debug.DrawLine(transform.position, Player1.transform.position, Color.magenta);
        Debug.DrawLine(transform.position, World.transform.position, Color.yellow);
        Debug.DrawLine(transform.position, MainCamera.transform.position, Color.cyan);
        if (Player2 != null)
        {
            Debug.DrawLine(Player1.transform.position, Player2.transform.position, Color.red);
            Debug.DrawLine(transform.position, Player2.transform.position, Color.magenta);
            distance1 = Vector3.Distance(Player1.transform.position, Player2.transform.position);
            center = (Player1.transform.position + Player2.transform.position) / 2;
            if (Player3 == null)
                longD = distance1;

            if (Player3 != null)
            {
                Debug.DrawLine(Player1.transform.position, Player3.transform.position, Color.blue);
                Debug.DrawLine(Player2.transform.position, Player3.transform.position, Color.green);
                Debug.DrawLine(transform.position, Player3.transform.position, Color.magenta);
                distance2 = Vector3.Distance(Player1.transform.position, Player3.transform.position);
                distance3 = Vector3.Distance(Player2.transform.position, Player3.transform.position);
                center = (Player1.transform.position + Player2.transform.position + Player3.transform.position) / 3;
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

        }

        transform.position = center;
        print("LongD:  " + longD);
        print("MidD:   " + midD);
        print("ShortD: " + shortD);

        if (Player3 != null)
        {
            if ((longD < 65) && (shortD > 15))
            {
                MainCamera.transform.LookAt(center);
                MainCamera.transform.position = center * 2;
                //Vector3 distanceVector = Vector3.Scale(center, new Vector3(4,4,4));
                //MainCamera.transform.position = Vector3.ClampMagnitude(distanceVector, 150.3f);
            } 
        }
        else
        {
            if (longD < 50)
            {
                MainCamera.transform.LookAt(center);
                MainCamera.transform.position = center * 2;
            }
        }
    }
}
