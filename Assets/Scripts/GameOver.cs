using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Text winLoseText;

	// Use this for initialization
	void Start () {

		winLoseText.text = PlayerPrefs.GetString("win");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
