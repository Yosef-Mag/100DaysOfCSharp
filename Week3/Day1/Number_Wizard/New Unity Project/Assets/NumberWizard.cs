using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
        int max;
        int min;
        int guess;
    
 
        void StartGame() {
            max =  1000;
            min = 1;
            guess = 500;
            Debug.Log("Welcome to number wizard...");
            Debug.Log("Pleas pick a number and don't tell me what is is..");
            Debug.Log("The highest number you can pick is:" + max);
            Debug.Log("The lowest number you can pick is is:" + min);
            Debug.Log("Tell me if your number is higher or lower than: " + guess);
            Debug.Log("Press Up if it's Higher \nPress Down if it's Lower\nPress Enter if your answer is Correct");
            max = max + 1;
        }
    void Start()
    {
     StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I am a genius!");
            StartGame();
        }
    }
     void NextGuess() {
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
    }
}
