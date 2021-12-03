using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickTackToeGame : MonoBehaviour
{
    public static TickTackToeGame instance;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

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
        else if (TickTackToeStats.buttonUsed[2] == player && TickTackToeStats.buttonUsed[4] == player && TickTackToeStats.buttonUsed[6] == player)
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
        switch (player)
        {
            case 1:
                TickTackToeStats.player1Won = true;
                Debug.Log("Player " + player + " won!");
                break;
            case 2:
                TickTackToeStats.player2Won = true;

                if (TickTackToeStats.computer)
                    Debug.Log("Computer won!");
                else
                    Debug.Log("Player " + player + " won!");
                break;
        }

        TickTackToeStats.gameRunning = false;

        for (int i = 0; i < TickTackToeStats.movesDone.Length; i++)
            Debug.Log(TickTackToeStats.movesDone[i]);
    }
}
