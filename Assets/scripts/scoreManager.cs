﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI; //imports UI code that we need

public class scoreManager : MonoBehaviour {
	//using UI for score
	public static int score;
	public GameObject currentCheckpoint;
	

	private PlayerMovement player;

	Text text;

	void Start()
	{
		text = GetComponent<Text> (); //sets the score to 0

		//score = 0;

		score = PlayerPrefs.GetInt ("CurrentScore");
	}

	void Update ()
	{
		if (score < 0)
			score = 0;

		text.text = "" + score;
	}
	//adding point
	public static void AddPoint (int pointsAdd)
	{
		score += pointsAdd;
		PlayerPrefs.SetInt ("CurrentScore", score);
	}

	//lose points
	public static void Reset()
	{
		score = 0;
		PlayerPrefs.SetInt ("CurrentScore", score);
	}


}
