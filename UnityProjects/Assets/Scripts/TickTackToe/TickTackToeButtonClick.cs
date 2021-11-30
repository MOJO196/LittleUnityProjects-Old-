using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickTackToeButtonClick : MonoBehaviour
{
    public int buttonPosition;
    public Image buttonImage;
    public int ButtonClick()
    {
        if (TickTackToeStats.buttonUsed[buttonPosition - 1] == 0 && TickTackToeStats.gameRunning)
        {
            TickTackToeStats.moves++;

            if (TickTackToeStats.player1ToMove)
            {
                buttonImage.color = Color.red;
                TickTackToeStats.buttonUsed[buttonPosition - 1] = 1;
                TickTackToeGame.instance.CheckGameState(1);
            }
            else
            {
                buttonImage.color = Color.blue;
                TickTackToeStats.buttonUsed[buttonPosition - 1] = 2;
                TickTackToeGame.instance.CheckGameState(2);
            }

            TickTackToeStats.player1ToMove = !TickTackToeStats.player1ToMove;
        }
        else if (!TickTackToeStats.gameRunning)
        {
            //Next Scene
        }
        else
        {
            return 1;
        }

        return 0;
    }
}
