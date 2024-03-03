using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    private bool isJumping = false;
    private Rigidbody rb;

    public float pushForce = 4.0f;
    private ControllerColliderHit contact;

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

     void OnControllerColliderHit(ControllerColliderHit hit)
    {
        contact = hit;
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic){
            body.velocity = hit.moveDirection * pushForce;
        }
    }
}