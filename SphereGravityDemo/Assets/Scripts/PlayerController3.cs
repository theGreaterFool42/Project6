using UnityEngine;
using System.Collections;

public class PlayerController3 : MonoBehaviour
{

    public float moveSpeed = 15;
    public float jumpSpeed = 250;
    private Vector3 moveDirection;



    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal3"), 0, Input.GetAxisRaw("Vertical3")).normalized;
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump3"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
            print("Jump3");
        }
    }
}
