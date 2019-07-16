using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maximum_val;
    int minimum_val;
    int wizard_guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        maximum_val = 1001;
        minimum_val = 1;
        wizard_guess = 500;

        Debug.Log("Welcome to NumberWizzard");
        Debug.Log("Pick a number between " + minimum_val + " and " + maximum_val + " don't tell me what it is...");
        Debug.Log("Tell me if your number is higher or lower than my guess");
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        Debug.Log("Is your number " + wizard_guess + "?");
    }


    // Update is called once per frame
    void Update()
    {
        //Code for reaction to pressing the up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimum_val = wizard_guess;
            next_wizard_guess();

        }

        //Code for reaction to pressing the down arrow
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximum_val = wizard_guess;
            next_wizard_guess();

        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Success!!!");
            StartGame();
        }
    }

    void next_wizard_guess()
    {
        wizard_guess = (maximum_val + minimum_val) / 2;
        Debug.Log("Ohk...So is it perhaps " + wizard_guess + "?");
    }
}
