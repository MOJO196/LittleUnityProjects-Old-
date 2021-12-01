using UnityEngine;
public static class TickTackToeStats
{
    //Ingame
    public static bool player1ToMove;
    public static bool gameRunning = true;
    public static int moves;
    public static int[] buttonUsed = new int[9];
    //GameModes
    public static bool computer = true;
    //Result
    public static bool draw;
    public static bool player1Won;
    public static bool player2Won;
}