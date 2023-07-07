using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpHeight = 300f;

    float xInput, yInput, jumpInput;

    public Rigidbody rb;

    int numJumps = 2;

    bool godmode = false;


    void Update()
    {
        ProcessInputs();
    }

    private void OnCollisionStay(Collision collision)
    {
        numJumps = 2;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        if (!godmode)
        {
            xInput = Input.GetAxis("Horizontal")*moveSpeed;
            yInput = Input.GetAxis("Vertical")*moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space) && numJumps > 1)
            {
                jumpInput = jumpHeight;
                numJumps--;
            }
        }

        if (godmode)
        {
            if (Input.GetKey(KeyCode.E) && godmode)
            {
                jumpInput = 1f;
            }
            if (Input.GetKey(KeyCode.Q) && godmode)
            {
                jumpInput = -1f;
            }
            if (Input.GetKey(KeyCode.W) && godmode)
            {
                yInput = 1f;
            }
            if (Input.GetKey(KeyCode.S) && godmode)
            {
                yInput = -1f;
            }
            if (Input.GetKey(KeyCode.A) && godmode)
            {
                xInput = -1f;
            }
            if (Input.GetKey(KeyCode.D) && godmode)
            {
                xInput = 1f;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            godmode = !godmode;
            rb.isKinematic = !rb.isKinematic;
        }

    }

    private void Move()
    {
        Vector3 moveVector = new Vector3(xInput, jumpInput, yInput);
        //moveVector += new Vector3(0f, jumpInput, 0f);

        if (!godmode)
        {
            rb.AddForce(moveVector);
            jumpInput = 0;
        }
        if (godmode)
        {
            rb.position += moveVector;
            jumpInput = xInput = yInput = 0;
        }
    }
}
