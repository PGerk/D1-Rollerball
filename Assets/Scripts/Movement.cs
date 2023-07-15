using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpHeight = 300f;

    float xInput, yInput, jumpInput;

    public Rigidbody rb;

    int numJumps = 2;

    bool godmode = false;

    public bool OnGround { get; private set; } = false;
    public bool HasInput => xInput != 0 || yInput != 0 || jumpInput != 0;

    void Update()
    {
        ProcessInputs();
    }

    private void OnCollisionStay(Collision collision)
    {
        numJumps = 2;
        OnGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        OnGround = false;
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

        //Load Main Menu on R press
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
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
