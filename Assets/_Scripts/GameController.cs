using UnityEngine;
using System.Collections;
using  UnityEngine.UI;
using UnityEngine.SceneManagement;
/**
 * This is a retro shooter game 
 * 
 * @FileName: GameController.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is GameController cs file for the game
 */

/**  
* <summary>  
* This is the GameController class which controls the whole game from top.  
* </summary>  
*   
* @class GameController  
*/
public class GameController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++
	private int _livesValue;
	private int _scoreValue;
	private AudioSource _endGameSound;

	//PUBLIC INSTANCE VARIABLE++++++++++++++++++++++++
	public int killerRelic1Number = 6; 
	public RelicController1 killerRelic;
	public int enemiesNumber = 6; 
	public EnemyControl enemies;


	[Header("Labels")]
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text FinalScoreLabel;
	[Header("Buttons")]
	public Button RestartButton;

	[Header ("Game Objects")]
	public GameObject myShip;
	public GameObject killerRelic1;
	public GameObject killerRelic2;
	public GameObject killerRelic3;
	public GameObject powerRelic1;
	public GameObject powerRelic2;

	//PUBLIC PROPERTIES++++++++++++++++++++++++++++++++

	public int LivesValue {
		get{ 
			return this._livesValue;
		}
		set{ 
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame();
			} else {
				this.LivesLabel.text = "LIVES: " + this._livesValue;
			}
		}
	}
	public int ScoreValue {
		get{ 
			return this._scoreValue;
		}
		set{ 
			this._scoreValue = value;
			this.ScoreLabel.text = "SCORE: " + this._scoreValue;
		}
	}



	//METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	/**
        * <summary>
        * This is the method for starting the GameController class
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {

		this.LivesValue = 50;
		this.ScoreValue = 0;
		this.GameOverLabel.gameObject.SetActive (false);
		this.FinalScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (false);

		this._endGameSound = this.GetComponent<AudioSource>();

		for (int count = 0; count < this.killerRelic1Number; count++) {
			Instantiate (this.killerRelic.gameObject);
		}
		for (int count = 0; count < this.enemiesNumber; count++) {
			Instantiate (this.enemies.gameObject);
		}

	}
	

	/**
        * <summary>
        * This method is called once per frame.
        * </summary>
        * 
        * @method Update
        * @returns {void} 
        */
	void Update () {
	
	}


	/**
        * <summary>
        * This private method is called to get  the game into an end.
        * </summary>
        * 
        * @method _endGame
        * @returns {void} 
        */
	private void _endGame(){
		this.GameOverLabel.gameObject.SetActive (true);
		this.FinalScoreLabel.text = "FINAL SCORE: " + this.ScoreValue;
		this.FinalScoreLabel.gameObject.SetActive (true);
		this.ScoreLabel.gameObject.SetActive (false);
		this.LivesLabel.gameObject.SetActive (false);
		this.myShip.gameObject.SetActive (false);
		this.killerRelic1.gameObject.SetActive (false);
		this.killerRelic2.gameObject.SetActive (false);
		this.killerRelic3.gameObject.SetActive (false);
		this.killerRelic.gameObject.SetActive (false);
		this.powerRelic1.gameObject.SetActive (false);
		this.powerRelic2.gameObject.SetActive (false);
		this.killerRelic.gameObject.SetActive (false);
		this.enemies.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (true);

		this._endGameSound.Play ();
	}

	public void RestartButton_Click(){
		SceneManager.LoadScene ("Game");
	}
}
