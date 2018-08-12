using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour // Script accesses,assgins Text function to scoreTextObject to Update score & UI
{
	public static GameManager instance = null; // Public static accessable from any script, equal to nothing to start
                                               // GameManager=type variable name instance 
	public GameObject scoreTextObject; // Public variable of scoretext GameObject in Hierarchy

	int score; // Private variable, keep the score running
	Text scoreText; // Private variable, where UI library functions are accessed through Text function

	void Awake ()
	{
        if (instance == null) // If instance does not exist(is nothing) then equals this script
			instance = this;
		else if (instance != null) // If already instance in place or trying to make second instance
            Destroy (gameObject); // Destroy (so no two GameManagers)


        scoreText = scoreTextObject.GetComponent<Text> (); // Gets Text library function to initalize the changing scoretextobject
		scoreText.text = "Your Score: " + score.ToString (); // Updates textbox and displays score as string
	}

	public void Collect(int disabledValue, GameObject disabledObject) // Connecting Collection script calling value and disobject 
    {	                                                              // Accesses determined value of object and object itself
    score = score + disabledValue; // Updates score
	scoreText.text = "Your Score:" + score.ToString (); // Updates UI
	}
}
