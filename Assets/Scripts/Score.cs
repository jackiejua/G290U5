using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;

    [SerializeField]
    private TextMeshProUGUI playerone_text;

    GameObject manager;

 //   [SerializeField]
//    private int playerone_score;

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreTrigger") && other.transform.position.y > transform.position.y)
        {
            score++;
            Debug.Log("Player Two Score: " + score);
            playerone_text.text = "Player 2: " + score;

            if(score == 10)
            {
                Debug.Log("Player Two Wins!");
                playerone_text.text = "Player 2 Wins!";
            }
           
        }
    }

     void Start()
    {
      //  manager = gameObject.FindGameObjectWithTag("manager");
      //  manager.GetComponent<PlayerManager>().score = score;
    }

}