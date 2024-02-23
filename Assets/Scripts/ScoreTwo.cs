using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTwo : MonoBehaviour
{
    public int score = 0;

    [SerializeField]
    private TextMeshProUGUI playertwo_text;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreTrigger") && other.transform.position.y > transform.position.y)
        {
            score++;
            Debug.Log("Player One Score: " + score);
            playertwo_text.text = "Player 1: " + score;
            if(score == 10)
            {
                Debug.Log("Player One Wins!");
                playertwo_text.text = "Player 1 Wins!";
            }
        }
    }
}