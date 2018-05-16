using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour 
{
	public static GameManager instance = null;

	public GameObject scoreTextObject;

	int score;
	Text scoreText;

	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);


		scoreText = scoreTextObject.GetComponent<Text> ();
		scoreText.text = "Your Score: " + score.ToString ();
	}

	public void Collect(int disabledValue, GameObject disabledObject)
	{
		score = score + disabledValue;
		scoreText.text = "Your Score:" + score.ToString ();
	}
}
