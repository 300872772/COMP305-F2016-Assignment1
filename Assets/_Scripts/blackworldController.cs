using UnityEngine;
using System.Collections;
/**
 * This is a retro shooter game 
 * 
 * @FileName: blackworldController.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is blackworldController cs file for the game
 */

/**  
* <summary>  
* This is the blackworldController class to control the back screen.  
* </summary>  
*   
* @class blackworldController  
*/
public class blackworldController : MonoBehaviour {
	//PRIVATE INTANSCE VARIABLES++++++++++++
	private int _speed;
	private Transform _transform;

	//PUBLIC PROPERTIES++++++++++++++++++++

	public int Speed {
		get{ 
			return this._speed;
		}
		set{ 
			this._speed = value;
		}
	}

	/**
        * <summary>
        * This is the method for starting the blackworldController class which initiates value
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

		newPosition.y -= this.Speed;

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

		if (this._transform.position.y <= -509) {

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

		Vector2 resetPosition = new Vector2 (0f, 510f);
		this._transform.position = resetPosition;
		this.Speed = 3;
	}

}
