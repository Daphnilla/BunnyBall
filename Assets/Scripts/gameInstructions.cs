using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class gameInstructions : MonoBehaviour
{
    public string GameInstructions = "Move the player by using the W, A, S, and D keys";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(GameInstructions); //prints onto console window
    }

}