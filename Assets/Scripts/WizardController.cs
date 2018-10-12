using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardController : MonoBehaviour {

    private GameLogic gameLogic;
    public Text startText, textNumber;
    public Button bttnDown, bttnUp, bttnEqual, bttnStart;
    public GameObject guessNumber;

    // Use this for initialization
    void Start () {
        
        gameLogic = new GameLogic();
        guessNumber.SetActive(false);
    }
    
      public void NumberHigher()
    {
        gameLogic.AdaptMin();
        textNumber.text = gameLogic.GetGuess();
    }

    public void NumberLower()
    {
        gameLogic.AdaptMax();
        textNumber.text = gameLogic.GetGuess();
    }

    
    public void NumberEqual()
    {
        guessNumber.SetActive(false);
        startText.text = gameLogic.GetGuess()+ " war deine Zahl! Nochmal spielen?";
        startText.enabled = true;
        bttnStart.GetComponentInChildren<Text>().text = "Start Game";
        bttnUp.enabled = false;
        bttnDown.enabled = false;
        bttnEqual.enabled = false;
        
    }

    public void StartGame()
    {
        gameLogic.StartGame();
        startText.enabled = false;
        bttnStart.GetComponentInChildren<Text>().text = "Restart Game";
        bttnStart.GetComponent<Image>().color = Color.yellow;
        guessNumber.SetActive(true);
        bttnUp.enabled = true;
        bttnDown.enabled = true;
        bttnEqual.enabled = true;
    }

    public void EndGame()
    {
        guessNumber.SetActive(false);
        startText.enabled = true;
        startText.GetComponentInChildren<Text>().text = "Start Game";
    }
}
