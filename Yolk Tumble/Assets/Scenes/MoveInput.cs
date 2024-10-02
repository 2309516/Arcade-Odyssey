using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInput : MonoBehaviour
{
    public float speed;
    
    float inputZ;
    float inputX;

    public Transform orientation;

    Vector3 direction;
    Rigidbody playerRigidbody;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.freezeRotation = true;

    }

    void Update()
    {
        movementInput();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movePlayer();
    }

    private void movementInput()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");

    }

    private void movePlayer()
    {
        direction = orientation.forward * inputZ + orientation.right * inputX;
        playerRigidbody.AddForce(direction.normalized * speed * 10f, ForceMode.Force);
    }
}
