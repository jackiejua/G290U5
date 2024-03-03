using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour, IGameManager
{

    public ManagerStatus status { get; private set; }

    public int health { get; private set; }
    public int maxHealth { get; private set; }

    public int score = 0;

    [SerializeField]
    private TextMeshProUGUI playerone_text;
     private TextMeshProUGUI playertwo_text;


    public void Startup()
    {
        Debug.Log("Player manager starting...");

        health = 50;
        maxHealth = 100;

        status = ManagerStatus.Started;
    }

    public void ChangeHealth(int value)
    {
        health += value;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health < 0)
        {
            health = 0;
        }

        Debug.Log($"Health: {health}/{maxHealth}");
    }

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
           
        } else if (other.gameObject.CompareTag("ScoreTrigger") && other.transform.position.y > transform.position.y)
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
