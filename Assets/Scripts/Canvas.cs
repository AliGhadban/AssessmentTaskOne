using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	// Starts the game 
	public void StartGame()
	{
		SceneManager.LoadScene(2);
	}

	// Loads the credits scene
	public void Credit()
	{
		SceneManager.LoadScene(1);
	}

	// Loads the Main Menu Scene
	public void Menu()
	{
		SceneManager.LoadScene(0);
	}

	// Quits the game
	public void Quit()
	{
		Application.Quit();
	}
}
