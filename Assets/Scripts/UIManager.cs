using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI playerone_text;

    [SerializeField]
    private int playerone_score;

    // Start is called before the first frame update
    void Start()
    {
        playerone_text.text = "Player One: " + playerone_score;
    }

    public void UpdateScore(int point)
    {
        playerone_score += point;
        playerone_text.text = "Player One: " + playerone_score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
