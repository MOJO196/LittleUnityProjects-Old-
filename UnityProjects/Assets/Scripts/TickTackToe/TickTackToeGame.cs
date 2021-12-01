using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickTackToeGame : MonoBehaviour
{
    public static TickTackToeGame instance;
    void Awake()
    {

        if (Random.value >= 0.5)
        {
            TickTackToeStats.player1ToMove = true;
        }

        TickTackToeStats.player1ToMove = false;

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void CheckGameState(int player)
    {
        //Rows
        if (TickTackToeStats.buttonUsed[0] == player && TickTackToeStats.buttonUsed[1] == player && TickTackToeStats.buttonUsed[2] == player)
            PlayerWon(player);
        else if (TickTackToeStats.buttonUsed[3] == player && TickTackToeStats.buttonUsed[4] == player && TickTackToeStats.buttonUsed[5] == player)
            PlayerWon(player);
        else if (TickTackToeStats.buttonUsed[6] == player && TickTackToeStats.buttonUsed[7] == player && TickTackToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        //Columns
        else if (TickTackToeStats.buttonUsed[0] == player && TickTackToeStats.buttonUsed[3] == player && TickTackToeStats.buttonUsed[6] == player)
            PlayerWon(player);
        else if (TickTackToeStats.buttonUsed[1] == player && TickTackToeStats.buttonUsed[4] == player && TickTackToeStats.buttonUsed[7] == player)
            PlayerWon(player);
        else if (TickTackToeStats.buttonUsed[2] == player && TickTackToeStats.buttonUsed[5] == player && TickTackToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        //Diagonals
        else if (TickTackToeStats.buttonUsed[0] == player && TickTackToeStats.buttonUsed[4] == player && TickTackToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        else if (TickTackToeStats.buttonUsed[2] == player && TickTackToeStats.buttonUsed[1] == player && TickTackToeStats.buttonUsed[6] == player)
            PlayerWon(player);
        //Check for draw
        else if (TickTackToeStats.moves == 9)
        {
            Debug.Log("Draw");
            TickTackToeStats.draw = true;
            TickTackToeStats.gameRunning = false;
        }
    }

    public void PlayerWon(int player)
    {
        if (player == 1)
            TickTackToeStats.player1Won = true;
        else
            TickTackToeStats.player2Won = true;

        TickTackToeStats.gameRunning = false;
        Debug.Log("Player " + player + " won!");
    }
}
