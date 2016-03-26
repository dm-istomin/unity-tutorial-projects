using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public BoardManager boardScript;
	public static GameManager instance = null;
	public int playerFoodPoints = 100;
	[HideInInspector] public bool playerTurn = true;

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

	public void GameOver () {
		enabled = false;
	}
}
