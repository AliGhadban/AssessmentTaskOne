﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player") {

			PlayerPrefs.SetString("win", "You Lose!");
			SceneManager.LoadScene("GameOver");
		}
	}
}
