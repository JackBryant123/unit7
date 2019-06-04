using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBet : MonoBehaviour
{
    int bet = 1;

    GameObject betGameGO;

    private void Start()
    {
        betGameGO = GameObject.Find("bet");
        betGameGO.GetComponent<Text>().text = bet.ToString();
        
    }


    public void MinusBet()
    {
        bet = bet -1;
        betGameGO.GetComponent<Text>().text = bet.ToString();
    }

    public void PlusBet()
    {
        bet = bet + 1;
        betGameGO.GetComponent<Text>().text = bet.ToString();
    }
}
