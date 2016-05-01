using UnityEngine;
using System.Collections;

public class MoveStorm : MonoBehaviour
{
    public float speed = 0.01f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
        transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * speed);
    }
}
