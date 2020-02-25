using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int minNumber;

    private int maxNumber;

    NumberWizard()
    {
        minNumber = 1;
        maxNumber = 1000 + 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number between " + minNumber + " and " + maxNumber);
        MakeGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = minNumber + ((maxNumber - minNumber) / 2);
            MakeGuess();

            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = minNumber + ((maxNumber - minNumber) / 2);
            MakeGuess();

            return;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("My guess is correct");

            return;
        }
    }

    void MakeGuess()
    {
        int guess = minNumber + ((maxNumber - minNumber) / 2);
        Debug.Log("Is your number higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
    }
}
