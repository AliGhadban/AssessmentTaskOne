using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	// Variables
	public string playerName;
	public bool isMoving;
	public float xPosition;
	public int score;

	// UI Elements
	public Text playerNameText;
	public Text isMovingText;
	public Text xPositionText;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		// Update all variables to text on canvas
		playerNameText.text = playerName;

		if (isMoving == true)
		{
			isMovingText.text = "Moving";
		}
		else
		{
			isMovingText.text = "Not Moving";
		}

		xPositionText.text = "Position: " + xPosition;

		scoreText.text = "Score: " + score;

		if (score == 9)
		{
			SceneManager.LoadScene("GameOver");
			PlayerPrefs.SetString("win", "You Win!");
		}
		
	}
}
