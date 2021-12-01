using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickTackToeGameController : MonoBehaviour
{
    public bool randomPlayerToBeginn;
    public bool player1ToBeginn;
    public bool againstComputer;
    public static TickTackToeGameController instance;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);

        if (Random.value >= 0.5 && randomPlayerToBeginn)
            TickTackToeStats.player1ToMove = true;
        else if (!randomPlayerToBeginn)
            TickTackToeStats.player1ToMove = player1ToBeginn;
        else TickTackToeStats.player1ToMove = false;

        TickTackToeStats.computer = againstComputer;
    }
}
