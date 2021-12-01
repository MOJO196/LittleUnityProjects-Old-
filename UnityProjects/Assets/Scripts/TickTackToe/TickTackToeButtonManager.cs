using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickTackToeButtonManager : MonoBehaviour
{
    public Button[] buttons = new Button[9];
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    public static TickTackToeButtonManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
        
        buttons[0] = button1;
        buttons[1] = button2;
        buttons[2] = button3;
        buttons[3] = button4;
        buttons[4] = button5;
        buttons[5] = button6;
        buttons[6] = button7;
        buttons[7] = button8;
        buttons[8] = button9;

        if (TickTackToeStats.computer == true && TickTackToeStats.player1ToMove == false)
            ComputerMove();
    }

    public void ComputerMove()
    {

        if (TickTackToeStats.gameRunning)
        {
            while (true)
            {
                int computerMove = Random.Range(0, 8);

                if (TickTackToeStats.buttonUsed[computerMove] == 0)
                {
                    buttons[computerMove].Select();
                    buttons[computerMove].onClick.Invoke();
                    break;
                }
            }
        }
    }
}
