using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeButtonManager : MonoBehaviour
{
    public Button[] buttons = new Button[9];

    public static TicTacToeButtonManager instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        if (TicTacToeStats.computer && !TicTacToeStats.player1ToMove)
        {
            SimulateNextMoves();
        }
    }

    public void ComputerMove()
    {
        if (TicTacToeStats.gameRunning && !TicTacToeStats.player1ToMove)
        {
            switch (TicTacToeStats.AILevel)
            {
                case 1:
                    RandomMove();
                    break;
                case 2:
                    SimulateNextMoves();
                    break;
                case 3:
                    break;
            }
        }
    }

    private void SimulateNextMoves()
    {
        int result;

        for (int i = 0; i < 9; i++)
        {
            if (TicTacToeStats.buttonUsed[i] == 0)
            {
                TicTacToeStats.buttonUsed[i] = 5;
                result = TicTacToeGame.instance.CheckGameState(2);
                Debug.Log(result);
                TicTacToeStats.buttonUsed[i] = 0;

                if (result != 0)
                {
                    Move(i);
                    break;
                }
                else if (result == 0 && i == 8)
                {
                    RandomMove();
                    break;
                }
            }
        }
    }

    private void Move(int position)
    {
        buttons[position].Select();
        buttons[position].onClick.Invoke();
    }

    private void RandomMove()
    {
        for (; ; )
        {
            int computerMove = Random.Range(0, 9);

            if (TicTacToeStats.buttonUsed[computerMove] == 0)
            {
                Move(computerMove);
                break;
            }
        }
    }
}
