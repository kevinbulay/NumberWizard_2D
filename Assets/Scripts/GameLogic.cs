using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic{
    private int min, max, guess;
    private bool mydebug = false;

    public GameLogic()
    {
        InitGame();
    }

    public void AdaptMax()
    {
        max = guess;
        CalcGuess();
    }

    public void AdaptMin()
    {
        min = guess;
        CalcGuess();
    }

    public string GetGuess()
    {
        return guess.ToString();
    }

    public void StartGame()
    {
        InitGame();
    }

    private void InitGame()
    {

        min = 1;
        max = 1000;
        guess = 500;
    }

    private void CalcGuess()
    {
        guess = (min + max) / 2;
    }

    private void MyDebug(string msg)
    {
        if (mydebug)
        {
            Debug.Log(msg);
        }
    }
}
