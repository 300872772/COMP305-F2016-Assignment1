using UnityEngine;
using System.Collections;

public class blackworldController : MonoBehaviour {
	//PUBLIC INTANSCE VARIABLES++++++++++++
	//[SerializeField]
	private int _speed;
	//private Transform _newTransform;
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

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> (); // get a ref to the TRansform of my ocean
		//this._newTransform = new Transform (); //instance a new Transform

		_reset ();

	}

	// Update is called once per frame
	void Update () {

		this._move();

		this._borderCheck();
	}

	/*
* this method moves the game object bdown the screen
	*/

	private void _move(){
		Vector2 newPosition;
		//	this._newTransform.position = newPosition;
		newPosition = this._transform.position;

		newPosition.y -= this.Speed;

		this._transform.position = newPosition;

	}

	/**
	 * this method checks to see if my game object has reached the top border 
	 */

	private void _borderCheck(){

		if (this._transform.position.y <= -509) {

			this._reset();

		}

	}

	/**
	 * this method resets the game object to it's original position
	 * 
	 * 
	 */ 

	private void _reset(){

		Vector2 resetPosition = new Vector2 (0f, 510f);
		this._transform.position = resetPosition;
		this.Speed = 3;
	}

}
