using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public int score = 0;
	public int vieCivil = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameOver(){
		
	}

	public void AddScore(int addScore){
		score += addScore;
	}

	public void dmgCivil(int dmg){
		vieCivil -= dmg;
	}
}
