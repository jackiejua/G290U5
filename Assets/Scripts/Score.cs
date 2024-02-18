using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreTrigger") && other.transform.position.y > transform.position.y)
        {
            score++;
            Debug.Log("Player Two Score: " + score);
        }
    }
}