using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float inputX;
    public float inputZ;
    public float rotateSpeed;
    public Rigidbody myRigidbody;

    public Transform orientation;
    public Transform player;
    public Transform playerObj;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = direction.normalized;

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        Vector3 inputDirection = orientation. forward * inputZ + orientation.right * inputX;

        if (inputDirection != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDirection.normalized, Time.deltaTime * rotateSpeed);
        }
    }
    void Move()
    {
        //get values for the X and Z inputs
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        //set the player velocity
        myRigidbody.velocity = new Vector3(inputX * speed, myRigidbody.velocity.y, inputZ * speed);
    }
    void RotatePlayer() 
    {
        Vector3 inputDirection = orientation. forward * inputZ + orientation.right * inputX;

        if (inputDirection != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDirection.normalized, Time.deltaTime * rotateSpeed);
        }
    }
}
