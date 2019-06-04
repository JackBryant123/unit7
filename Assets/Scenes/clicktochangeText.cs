using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicktochangeText : MonoBehaviour
{
    public int playerScore = 0;
    public int botsScore = 0;
    public Text playerScoreText = null;
    public Text computerScore = null;
    public GameObject win;
    public GameObject lose;


    public void UpdateScorePlayer(int newValue)
    {
        playerScore = playerScore + newValue;

        if (playerScore == 10)
        {
            win.SetActive(true);
        }

        playerScoreText.text = playerScore.ToString();
    }

    public void UpdateScoreComputer(int newValue)
    {
        botsScore = botsScore + newValue;

        if (botsScore == 10)
        {
            lose.SetActive(true);
        }

        computerScore.text = botsScore.ToString();
    }
}
