using UnityEngine;

public class BikeController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public float rotationSpeed = 4f;

    bool move = false;
    bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            move = false;
        }
    }

    private void FixedUpdate()
    {
        if (move == true)
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
