using UnityEngine;
using System.Collections;

public class PlayerController1 : MonoBehaviour
{

    public float moveSpeed = 15;
    public float jumpSpeed = 250;
    private Vector3 moveDirection;
    private string[] playerInput1 = new string[3];
    private string[] playerInput2 = new string[3];
    private string[] playerInput3 = new string[3];
    //private string horizontalInput;
    //private string verticalInput;
    //private string jumpInput;


    void Start()
    {
        playerInput1[0] = "Horizontal1";
        playerInput2[0] = "Horizontal2";
        playerInput3[0] = "Horizontal3";
        playerInput1[1] = "Vertical1";
        playerInput2[1] = "Vertical2";
        playerInput3[1] = "Vertical3";
        playerInput1[2] = "Jump1";
        playerInput2[2] = "Jump2";
        playerInput3[2] = "Jump3";

       
    }


    // Update is called once per frame
    void Update()
    {
        
        //switch (currentPlayer)
        //{
        //    case 1:
        //        horizontalInput = playerInput1[0];
        //        verticalInput = playerInput1[1];
        //        jumpInput = playerInput1[2];
        //        break;
        //    case 2:
        //        horizontalInput = playerInput2[0];
        //        verticalInput = playerInput2[1];
        //        jumpInput = playerInput2[2];
        //        break;
        //    case 3:
        //        horizontalInput = playerInput3[0];
        //        verticalInput = playerInput3[1];
        //        jumpInput = playerInput3[2];
        //        break;
        //    default:
        //        break;
        //}


        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    currentPlayer += 1;
        //    if (currentPlayer == 4)
        //        currentPlayer = 1;
        //    print(currentPlayer);
        //}

        if (this.name == "Player1(Clone)")
        {
            moveDirection = new Vector3(Input.GetAxisRaw(playerInput1[0]), 0, Input.GetAxisRaw(playerInput1[1])).normalized;
            if (Input.GetButtonDown(playerInput1[2]))
            {
                GetComponent<Rigidbody>().AddForce(transform.up * jumpSpeed);
            } 
        }
        else if (this.name == "Player2(Clone)")
        {
            moveDirection = new Vector3(Input.GetAxisRaw(playerInput2[0]), 0, Input.GetAxisRaw(playerInput2[1])).normalized;
            if (Input.GetButtonDown(playerInput2[2]))
            {
                GetComponent<Rigidbody>().AddForce(transform.up * jumpSpeed);
            }
        }
        else if (this.name == "Player3(Clone)")
        {
            moveDirection = new Vector3(Input.GetAxisRaw(playerInput3[0]), 0, Input.GetAxisRaw(playerInput3[1])).normalized;
            if (Input.GetButtonDown(playerInput3[2]))
            {
                GetComponent<Rigidbody>().AddForce(transform.up * jumpSpeed);
            }
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
    }
}
