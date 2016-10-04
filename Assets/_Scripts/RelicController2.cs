using UnityEngine;
using System.Collections;
/**
 * This is a retro shooter game 
 * 
 * @FileName: RelicController2.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is RelicController2 cs file for the game
 */

/**  
* <summary>  
* This is the RelicController2 class to control Relics.  
* </summary>  
*   
* @class RelicController2  
*/
public class RelicController2 : MonoBehaviour {

	//private Transform _newTransform;
	private Transform _transform;
	private bool _direction;

	//PUBLIC INTANSCE VARIABLES++++++++++++
	private int _speed;
	private int _drift;


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
        * This is the method for starting the RelicController2 class which initiates value
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

		if (this._transform.position.y <= -300) {

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
		this.Speed = Random.Range(4,10);

		this.Drift = Random.Range (-2, 2);
		Vector2 resetPosition = new Vector2 (Random.Range(-290f,290f), 400f);
		this._transform.position = resetPosition;
	
	}

}
