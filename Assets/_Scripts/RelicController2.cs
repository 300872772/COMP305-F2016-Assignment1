using UnityEngine;
using System.Collections;

public class RelicController2 : MonoBehaviour {

	//PRIVATE INTANSCE VARIABLES++++++++++++
	private int _speed;
	private int _drift;
	private Transform _transform;
	private bool _direction;
	private AudioSource _audio;
	private GameController _controller;

	//PUBLIC INTANSCE VARIABLES++++++++++++
	//[SerializeField]
	public int Health = 2;
	public Transform Explosion;
	public AudioSource HitSound;



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
	 * this method checks to see if my game object has reached the top border 
	 */

	private void _borderCheck(){

		if (this._transform.position.y <= -300) {

			this._reset();

		}

	}

	/**
	 * this method resets the game object to it's original position
	 * 
	 * 
	 */ 

	private void _reset(){
		this.Speed = Random.Range(4,10);

		this.Drift = Random.Range (-2, 2);
		Vector2 resetPosition = new Vector2 (Random.Range(-290f,290f), 400f);
		this._transform.position = resetPosition;
	
	}


	void OnCollisionEnter2D(Collision2D theCollision)
	{
		// Uncomment this line to check for collision
		//Debug.Log("Hit"+ theCollision.gameObject.name);
		// this line looks for "laser" in the names of
		// anything collided.
		if(theCollision.gameObject.name.Contains("Laser"))
		{
			LaserBehaviour laser =
				theCollision.gameObject.GetComponent
				("LaserBehaviour") as LaserBehaviour;
			Health -= laser.Damage;
			//Destroy (theCollision.gameObject);

			Vector2 newPosition;
			//	this._newTransform.position = newPosition;
			newPosition = this._transform.position;

			newPosition.y = -340 ;


				this._reset();

		
			// Plays a sound from this object's AudioSource
			//this._audio.Play();
			this.HitSound.Play();
		}

		if (theCollision.gameObject.name.Contains ("Player Ship")) {
			//_controller.DecreaseLives (1);
		}

		if (Health <= 0)
		{
			// Check if explosion was set
			if(Explosion)
			{
				GameObject exploder = ((Transform)Instantiate(Explosion, this.
					transform.position, this.transform.rotation)).gameObject;
				Destroy(exploder, 2.0f);
			}

			//_controller.KilledEnemy();
		//	_controller.IncreaseScore(10);


			//Destroy (this.gameObject);
		}
	}

}
