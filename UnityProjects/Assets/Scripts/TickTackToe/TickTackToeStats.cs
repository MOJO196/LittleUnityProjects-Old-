using UnityEngine;
public static class TickTackToeStats
{
    //Ingame
    public static bool player1ToMove;
    public static bool gameRunning = true;
    public static int moves;
    public static int[] buttonUsed = new int[9];
    //GameModes
    public static bool computer; //AI mode
    public static int computerMove;
    //Result
    public static bool draw;
    public static bool player1Won;
    public static bool player2Won;

    public static void ComputerMove()
    {
        int computerMove = Random.Range(0,8);
    }
}