using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BaseRotation : MonoBehaviour
{
    public float speed = 50;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        //transform.position += new Vector3(Input.GetAxis("Horizontal") * 0.01f, 0, 0);
        //transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * 0.01f);
    }
}
