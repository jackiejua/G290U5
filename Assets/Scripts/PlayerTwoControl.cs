using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    private bool isJumping = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Vector3 movement = transform.forward * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(KeyCode.J))
        {
            Vector3 movement = -transform.right * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(KeyCode.M))
        {
            Vector3 movement = -transform.forward * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(KeyCode.L))
        {
            Vector3 movement = transform.right * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKeyDown(KeyCode.K) && !isJumping)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}