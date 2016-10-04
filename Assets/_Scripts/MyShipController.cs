using UnityEngine;
using System.Collections;

/**
 * This is a retro shooter game 
 * 
 * @FileName: MyShipController.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is MyShipController cs file for the game
 */

/**  
* <summary>  
* This is the MyShipController class which defines how Avater will be controlled.  
* </summary>  
*   
* @class MyShipController  
*/

public class MyShipController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE+++++++++++++++++++
	private Transform _tranform;
	//private AudioSource[] Sounds;

	//PUBLIC INSTANCE VARIABLE++++++++++++++++++
	public AudioSource HitSound;
	public AudioSource PowerUpSound;
	public GameController gameController;


	/**
        * <summary>
        * This is the method for starting the MyShipController class which initiates value
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {
	
		this._tranform = this.GetComponent<Transform> ();
		//this.Sounds = this.GetComponents<AudioSource> ();
		//this._hitSound = this.Sounds[1];
		//this._powerUpSound = this.Sounds[2];
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
	
		//Input.mousePosition.x;

		this._tranform.position = new Vector2(Mathf.Clamp( Input.mousePosition.x-246f,-246f,246f) ,-170f);


	}
	/**
        * <summary>
        * This private method is called once there is any collusion.
        * </summary>
        * 
        * @method OnTriggerEnter2D
        * @returns {void} 
        * @param {Collider2D} other
        */

	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("killerRelic1")){
			this.HitSound.Play ();
			this.gameController.LivesValue -= 1;
			//Debug.Log ("killerRelic1 Hit");
		}else if(other.gameObject.CompareTag("killerRelic2")){
			this.HitSound.Play ();
			this.HitSound.Play ();
			this.gameController.LivesValue -= 2;
			//Debug.Log ("killerRelic2 Hit");
		}else if(other.gameObject.CompareTag("killerRelic3")){
			this.HitSound.Play ();
			this.HitSound.Play ();
			this.HitSound.Play ();
			this.gameController.LivesValue -= 3;
			//Debug.Log ("killerRelic3 Hit");
		}else if(other.gameObject.CompareTag("enemyShip")){
			this.HitSound.Play ();
			this.HitSound.Play ();
			this.HitSound.Play ();
			this.gameController.LivesValue -= 3;
			//Debug.Log ("killerRelic3 Hit");
		}
		else if(other.gameObject.CompareTag("powerRelic1")){
			this.PowerUpSound.Play ();
			this.gameController.ScoreValue += 100;
			//Debug.Log ("powerRelic Hit");
		}
		else if(other.gameObject.CompareTag("powerRelic2")){
			this.PowerUpSound.Play ();
			this.gameController.ScoreValue += 200;
			//Debug.Log ("powerRelic Hit");
		}

	}


}
