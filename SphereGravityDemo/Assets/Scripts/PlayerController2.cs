using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{

    public float moveSpeed = 15;
    public float jumpSpeed = 250;
    private Vector3 moveDirection;



    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal2"), 0, Input.GetAxisRaw("Vertical2")).normalized;
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump2"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
            print("Jump2");
        }
    }
}
