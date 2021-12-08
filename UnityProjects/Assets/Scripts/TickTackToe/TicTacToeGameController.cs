using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGameController : MonoBehaviour
{
    public bool randomPlayerToBeginn;
    public bool player1ToBeginn;
    public bool againstComputer;
    public int AILevel;
    public static TicTacToeGameController instance;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);
        StartGame();
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
