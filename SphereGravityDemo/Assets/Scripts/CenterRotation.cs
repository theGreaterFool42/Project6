using UnityEngine;
using System.Collections;

public class CenterRotation : MonoBehaviour
{
    public GameObject World;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gravityUp = (World.transform.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.FromToRotation(World.transform.up, gravityUp) * World.transform.rotation;
        World.transform.rotation = Quaternion.Slerp(World.transform.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
