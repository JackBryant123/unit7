using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    enum elements { Scissor = 1, Paper, Rock }

    private int playerChoose = -1;
    private int botChoose = -1;

    private bool playersTurn = true;

    public GameObject WinnerText;

    public Sprite paperImage, rockImage, scissorImage;
    public GameObject botChooseImage;
    public int winnings;

    // Update is called once per frame
    void Update()
    {

        if (playersTurn && playerChoose == -1) return;

        else
        {
            BotChoose();
            CheckWinner();
            playerChoose = -1;
            playersTurn = true;
        }

    }

    void CheckWinner()
    {
        if(playerChoose == botChoose)
        {
            //draw
            WinnerText.GetComponent<Text>().text = "DRAW";
        }

        else if(playerChoose == (int)elements.Paper && botChoose == (int)elements.Rock)
        {
            WinLogic();
        }
        else if (playerChoose == (int)elements.Rock && botChoose == (int)elements.Paper)
        {
            LoseLogic();
        }
        else if (playerChoose == (int)elements.Scissor && botChoose == (int)elements.Rock)
        {
            LoseLogic();
        }
        else if (playerChoose == (int)elements.Rock && botChoose == (int)elements.Scissor)
        {
            WinLogic();
        }

        else if (playerChoose == (int)elements.Scissor && botChoose == (int)elements.Paper)
        {
            WinLogic();
        }
        else if (playerChoose == (int)elements.Paper && botChoose == (int)elements.Scissor)
        {
            LoseLogic();
        }

    }

    private void WinLogic()
    {

        GameObject bet = GameObject.Find("bet");

        int.TryParse( bet.GetComponent<Text>().text, out winnings);

        //player wins
        WinnerText.GetComponent<Text>().text = "Player Wins";
        var ClicktochangeText = GameObject.FindObjectOfType<clicktochangeText>();
        ClicktochangeText.UpdateScorePlayer(winnings);
    }

    private void LoseLogic()
    {
        GameObject bet = GameObject.Find("bet");

        int.TryParse(bet.GetComponent<Text>().text, out winnings);

        WinnerText.GetComponent<Text>().text = "Bot Wins";
        var ClicktochangeText = GameObject.FindObjectOfType<clicktochangeText>();
        ClicktochangeText.UpdateScoreComputer(winnings);
    }

    public void PlayerChoose(int choose)
    {
        playerChoose = choose;
        playersTurn = false; //Now Bots Turn
    }

    public void BotChoose()
    {
        botChoose = Random.Range(1, 4);

        if(botChoose == 1)
        {
            botChooseImage.GetComponent<Image>().sprite = scissorImage;
        }
        else if (botChoose == 2)
        {
            botChooseImage.GetComponent<Image>().sprite = paperImage;
        }
        else
        {
            botChooseImage.GetComponent<Image>().sprite = rockImage;
        }
    }
}

