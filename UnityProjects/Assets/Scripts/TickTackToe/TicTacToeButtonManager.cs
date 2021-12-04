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
            ComputerMove();
        }
    }

    public void ComputerMove()
    {
        if (TicTacToeStats.gameRunning)
        {
            //AI
            while (true)
            {
                int computerMove = Random.Range(0, 9);

                if (TicTacToeStats.buttonUsed[computerMove] == 0)
                {
                    buttons[computerMove].Select();
                    buttons[computerMove].onClick.Invoke();
                    break;
                }
            }

            //Better AI
        }
    }
}
