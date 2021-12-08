using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeMenuButtons : MonoBehaviour
{
    public bool randomPlayerToBeginn;
    public bool player1ToBeginn;
    public bool againstComputer;
    public int AILevel;
    public void ResetButton()
    {
        if (!TicTacToeStats.gameRunning)
        {
            TicTacToeGameController.instance.StartGame();
        }
    }

    public void StartGame()
    {
        if (Random.value >= 0.5 && randomPlayerToBeginn)
            TicTacToeStats.player1ToMove = true;
        else if (!randomPlayerToBeginn)
            TicTacToeStats.player1ToMove = player1ToBeginn;
        else
            TicTacToeStats.player1ToMove = false;

        TicTacToeStats.computer = againstComputer;
        TicTacToeStats.AILevel = AILevel;
        TicTacToePlayerToMove.instance.PlayerToMove();
    }
}