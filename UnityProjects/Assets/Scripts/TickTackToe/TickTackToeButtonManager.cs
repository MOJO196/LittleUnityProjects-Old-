using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickTackToeButtonManager : MonoBehaviour
{
    public Button[] buttons = new Button[9];

    public static TickTackToeButtonManager instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);

        if (TickTackToeStats.computer == true && TickTackToeStats.player1ToMove == false)
            ComputerMove();
    }

    public void ComputerMove()
    {
        if (TickTackToeStats.gameRunning)
        {
            //AI Level 1
            while (true)
            {
                int computerMove = Random.Range(0, 9);

                if (TickTackToeStats.buttonUsed[computerMove] == 0)
                {
                    buttons[computerMove].Select();
                    buttons[computerMove].onClick.Invoke();
                    break;
                }
            }
            //AI Level 2
            //AI Level 3
        }
    }
}
