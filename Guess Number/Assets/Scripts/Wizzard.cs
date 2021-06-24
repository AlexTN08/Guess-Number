using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Wizzard : MonoBehaviour
{

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


   

    // Start is called before the first frame update
    void Start()
    {
      StartGame();
      
    }



    public void OnPressHigher()
    {
        min = guess + 1;
        GuessNumber();
    }


    public void OnPressLower()
    {
        max = guess - 1;
        GuessNumber();
    }

    void StartGame()
    {
        GuessNumber();
        max = max + 1;
    }

    void GuessNumber()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
