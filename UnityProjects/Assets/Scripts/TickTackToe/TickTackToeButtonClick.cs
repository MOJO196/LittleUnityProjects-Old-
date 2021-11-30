using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickTackToeButtonClick : MonoBehaviour
{
    public int buttonPosition;
    public void ButtonClick()
    {
        if (TickTackToeStats.buttonUsed[buttonPosition-1] == 0 && TickTackToeStats.gameRunning)
        {
            TickTackToeStats.moves++;

            if (TickTackToeStats.player1ToMove)
            {
                Debug.Log("X"); //Grafical
                TickTackToeStats.buttonUsed[buttonPosition-1] = 1;
                TickTackToeGame.instance.CheckGameState(1);
            } 
            else 
            {
                Debug.Log("O"); //Grafical
                TickTackToeStats.buttonUsed[buttonPosition-1] = 2;
                TickTackToeGame.instance.CheckGameState(2);
            }   
        
            TickTackToeStats.player1ToMove = !TickTackToeStats.player1ToMove;
        }
        else
        {
            //Next Scene
        }
    }
}
