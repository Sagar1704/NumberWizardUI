using System.Collections;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int max;
    [SerializeField] int min;

    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    ArrayList previousGuesses;


    // Use this for initialization
    void Start () {
        StartGame();
    }

    public void OnPressHigher() {
        min = guess;
        FindGuess();
    }

    public void OnPressLower() {
        max = guess;
        FindGuess();
    }

    private void StartGame() {
        FindGuess();
    }

    private void FindGuess() {
        guess = Random.Range(min, max + 1);
        if(previousGuesses != null && previousGuesses.Contains(guess)) {
            FindGuess();
        } else {
            if(previousGuesses == null) {
                previousGuesses = new ArrayList();
            }
        }
        previousGuesses.Add(guess);
        guessText.text = guess.ToString();
    }
}
