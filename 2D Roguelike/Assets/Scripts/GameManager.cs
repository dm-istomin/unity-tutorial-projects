﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public BoardManager boardScript;
	public static GameManager instance = null;

	private int level = 3;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		DontDestroyOnLoad(gameObject);
		boardScript = GetComponent<BoardManager>();
		InitGame();
	}

	void InitGame () {
		boardScript.SetupScene(level);
	}
}
