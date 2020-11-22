using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{ 
    int min = 1;
    int max = 200;
    int guess;

    public Text changingNumbers;
    public GameObject lower, higher, newGame, correct;

    void Start()
    {
        NewGame();
    }


    public void Lower()
    {
        max = guess - 1;
        NextGuess();

    }

    public void Higher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void Correct()
    {
        lower.SetActive(false);
        higher.SetActive(false);
        correct.SetActive(false);
        newGame.SetActive(true);

        
    }

    public void NewGame()
    {
        lower.SetActive(true);
        higher.SetActive(true);
        correct.SetActive(true);
        newGame.SetActive(false);
        min = 1;
        max = 200;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        changingNumbers.text = guess.ToString(); 
    }
}
