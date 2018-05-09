using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    int maxGuessesAllowed = 10;
    public Text text;

    void Start () {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        max = max + 1;
    }


    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel("Win");
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
