using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGame : MonoBehaviour
{
    public static TicTacToeGame instance;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    public int CheckGameState(int player)
    {
        //Rows   
        if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[1] == player && TicTacToeStats.buttonUsed[2] == player)
            return 1;
        else if (TicTacToeStats.buttonUsed[3] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[5] == player)
            return 2;
        else if (TicTacToeStats.buttonUsed[6] == player && TicTacToeStats.buttonUsed[7] == player && TicTacToeStats.buttonUsed[8] == player)
            return 3;
        //Columns
        else if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[3] == player && TicTacToeStats.buttonUsed[6] == player)
            return 4;
        else if (TicTacToeStats.buttonUsed[1] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[7] == player)
            return 5;
        else if (TicTacToeStats.buttonUsed[2] == player && TicTacToeStats.buttonUsed[5] == player && TicTacToeStats.buttonUsed[8] == player)
            return 6;
        //Diagonals
        else if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[8] == player)
            return 7;
        else if (TicTacToeStats.buttonUsed[2] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[6] == player)
            return 8;
        else
            return 0;
    }


    public void CheckPlayerWon(int player)
    {
        //Rows
        if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[1] == player && TicTacToeStats.buttonUsed[2] == player)
            PlayerWon(player);
        else if (TicTacToeStats.buttonUsed[3] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[5] == player)
            PlayerWon(player);
        else if (TicTacToeStats.buttonUsed[6] == player && TicTacToeStats.buttonUsed[7] == player && TicTacToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        //Columns
        else if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[3] == player && TicTacToeStats.buttonUsed[6] == player)
            PlayerWon(player);
        else if (TicTacToeStats.buttonUsed[1] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[7] == player)
            PlayerWon(player);
        else if (TicTacToeStats.buttonUsed[2] == player && TicTacToeStats.buttonUsed[5] == player && TicTacToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        //Diagonals
        else if (TicTacToeStats.buttonUsed[0] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[8] == player)
            PlayerWon(player);
        else if (TicTacToeStats.buttonUsed[2] == player && TicTacToeStats.buttonUsed[4] == player && TicTacToeStats.buttonUsed[6] == player)
            PlayerWon(player);
        //Check for draw
        else if (TicTacToeStats.moves == 9)
        {
            Debug.Log("Draw");
            TicTacToeStats.draw = true;
            TicTacToeStats.gameRunning = false;
        }
    }

    public void PlayerWon(int player)
    {
        switch (player)
        {
            case 1:
                Debug.Log("Player " + player + " won!");
                break;
            case 2:
                if (TicTacToeStats.computer)
                    Debug.Log("Computer won!");
                else
                    Debug.Log("Player " + player + " won!");
                break;
        }

        TicTacToeStats.gameRunning = false;
    }
}
