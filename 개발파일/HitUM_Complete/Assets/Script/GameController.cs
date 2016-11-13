using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	public GUIText heartText;
	private int scoreShooter;
	private int heartShooter;
	void Start () {
		scoreShooter = 0;
		heartShooter = 5;
		UpdateScore ();
		UpdateHeart ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddScore (int Value){
		scoreShooter += Value;
		UpdateScore();
	}
	void UpdateScore(){
		scoreText.text = "점수 : "+scoreShooter;
	}
	public void AttackHeart(){
		heartShooter -= 1;
		Debug.Log (heartShooter);
		UpdateHeart ();
	}
	void UpdateHeart(){
		heartText.text = "라이프 : " + heartShooter;
	}
	public int GetHeart(){
		return heartShooter;
	}
}
