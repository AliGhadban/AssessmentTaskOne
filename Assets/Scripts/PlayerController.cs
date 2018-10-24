using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Variables
	public float moveSpeed;

	public string playerName;

	public float playerXPosition;

	GameManager gameManager;

	// Use this for initialization
	void Start () {

		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		gameManager.playerName = playerName;

	}
	
	// Update is called once per frame
	void Update () {

		Movement();

		playerXPosition = transform.position.x;
		gameManager.xPosition = playerXPosition;
		
	}

	// Moves the player
	void Movement()
	{

		// Horizontal Movement
		if (Input.GetAxis("Horizontal") > 0.1f)
		{
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetAxis("Horizontal") < -0.1f)
		{
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
		}

		// Vertical Movement
		if (Input.GetAxis("Vertical") > 0.1f)
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetAxis("Vertical") < -0.1f)
		{
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
		}

		// Check if movement button pressed
		if (Input.GetAxis("Horizontal") == 0.0f && Input.GetAxis("Vertical") == 0.0f)
		{
			gameManager.isMoving = false;
		}
		else
		{
			gameManager.isMoving = true;
		}

	}
}
