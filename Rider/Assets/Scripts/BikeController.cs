using UnityEngine;

public class BikeController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public float rotationSpeed = 4f;

    bool moveForward = false;
    bool moveBackward = false;
    bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            moveForward = true;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            moveBackward = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            moveForward = false;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            moveBackward = false;
        }
    }

    private void FixedUpdate()
    {
        if (moveForward == true)
        {
            if (isGrounded)
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(rotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }

        if (moveBackward == true)
        {
            if (isGrounded)
            {
                rb.AddForce(transform.right * -speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(-rotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }
    }

    private void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D()
    {
        isGrounded = false;
    }
}
