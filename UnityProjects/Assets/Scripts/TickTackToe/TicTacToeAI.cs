﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeAI : MonoBehaviour
{
    public static TicTacToeAI instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(this.gameObject);
    }
}
