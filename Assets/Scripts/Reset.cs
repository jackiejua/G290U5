using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Vector3 respawnPosition = new Vector3(8, 1.5f, -5);

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            transform.position = respawnPosition;
        }
    }
}