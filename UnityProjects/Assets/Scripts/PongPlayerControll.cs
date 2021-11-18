using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PongPlayerControll : MonoBehaviour
{
    private float speed;
    private int playerID;
    private string playerInput;
    // Start is called before the first frame update
    void Start()
    {
        if (playerID == 0)
        {
            playerInput = "PongPlayer1";
        } 
        else if (playerID == 1) 
        {
            playerInput = "PongPlayer2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
