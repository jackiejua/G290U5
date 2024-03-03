using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneControl : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    private bool isJumping = false;

    public float pushForce = 4.0f;
    private Rigidbody rb;

    private ControllerColliderHit contact;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movement = -transform.right * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 movement = -transform.forward * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 movement = transform.right * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = transform.forward * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKeyDown(KeyCode.S) && !isJumping)
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