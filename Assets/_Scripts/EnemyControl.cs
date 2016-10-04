using UnityEngine;
using System.Collections;
/**
 * This is a retro shooter game 
 * 
 * @FileName: EnemyControl.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is EnemyControl cs file for the game
 */

/**  
* <summary>  
* This is the EnemyControl class to control enemies.  
* </summary>  
*   
* @class MenuController  
*/
public class EnemyControl : MonoBehaviour {

	//PUBLIC INTANSCE VARIABLES++++++++++++
	//[SerializeField]
	private int _speed;
	private int _drift;
	//private Transform _newTransform;
	private Transform _transform;

	private bool _direction;

	//PUBLIC PROPERTIES++++++++++++++++++++

	public int Speed {
		get{ 
			return this._speed;
		}
		set{ 
			this._speed = value;
		}
	}
	public int Drift {
		get{ 
			return this._drift;
		}
		set{ 
			this._drift = value;
		}
	}

	/**
        * <summary>
        * This is the method for starting the EnemyControl class which initiates value
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {
		this._transform = this.GetComponent<Transform> (); // get a ref to the TRansform of my ocean
		//this._newTransform = new Transform (); //instance a new Transform

		_reset ();

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

		this._move();

		this._borderCheck();
	}

	/**
        * <summary>
        * This private method is called to move the object on screen.
        * </summary>
        * 
        * @method _move
        * @returns {void} 
        */
	private void _move(){
		Vector2 newPosition;
		//	this._newTransform.position = newPosition;
		newPosition = this._transform.position;

		newPosition.y -= this.Speed ;

		/*if (_direction == false) {
			newPosition.x -= this.Speed ;
		}
		if (_direction == true) {
			newPosition.x += this.Speed ;
		}*/
		newPosition.x += this.Drift ;

		this._transform.position = newPosition;

	}

	/**
        * <summary>
        * This private method is check the border of the game screen for objects.
        * </summary>
        * 
        * @method _borderCheck
        * @returns {void} 
        */
	private void _borderCheck(){

		if (this._transform.position.y <= -280) {

			this._reset();

		}

	}

	/**
	* <summary>
	* This private method resets the game object to it's original position.
		* </summary>
		* 
		* @method _reset
		* @returns {void} 
	*/
	private void _reset(){
		this.Speed = Random.Range(4,7);
		this.Drift = Random.Range (-3, 3);
		if (this.Drift == 0) {
			this.Drift = 1;
		}
		Vector2 resetPosition = new Vector2 (Random.Range(-280f,280f), Random.Range(320f,400f));
		this._transform.position = resetPosition;

	}

}
