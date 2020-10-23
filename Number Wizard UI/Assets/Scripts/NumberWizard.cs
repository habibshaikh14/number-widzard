using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessTextObject;
    int guess;

    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = (guess + 1 <= max) ? (guess + 1) : guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = (guess - 1 >= min) ? (guess - 1) : guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessTextObject.text = guess.ToString();
    }
}
