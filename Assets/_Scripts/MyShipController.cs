/**
 * This is a retro shooter game 
 * 
 * @FileName: MyShipController.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is MyShipController cs file for the game
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**  
 * <summary>  
 * This is the MyShipController class which defines how Avater will behave.  
 * </summary>  
 *   
 * @class MyShipController  
 */
public class MyShipController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE+++++++++++++++++++
	private Transform _tranform;
	private float _currentSpeed = 0.0f;
	private Vector3 _lastMovement = new Vector3();
	private float _timeTilNextFire = 0.0f;
	private AudioSource _audioSource;

	//PUBLIC INSTANCE VARIABLE++++++++++++++++++
	public AudioSource HitSound;
	public AudioSource PowerUpSound;
	public AudioSource ShootSound;
	public GameController gameController;
	public float PlayerSpeed = 4.0f;
	public Transform Laser;
	public float LaserDistance = .2f;
	public float TimeBetweenFires = .3f;
	public List<KeyCode> ShootButton;



	//METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	/**
        * <summary>
        * This is the method for starting the MyShipController class
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {
	
		this._tranform = this.GetComponent<Transform> ();

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


		this._tranform.position = new Vector2(Mathf.Clamp( Input.mousePosition.x-246f,-246f,246f) ,-170f);

		//if(Input.GetMouseButton(0))

		//foreach (KeyCode element in ShootButton)
		//{
				if(Input.GetMouseButton(0) )
			{
				_timeTilNextFire = TimeBetweenFires;
				ShootLaser();
				//break;
			}
	//	}
		_timeTilNextFire -= Time.deltaTime;


	}
	/**
        * <summary>
        * This method is for shooting laser.
        * </summary>
        * 
        * @method ShootLaser
        * @returns {void} 
        */
	void ShootLaser()
	{
		this.ShootSound.Play ();


		Vector3 laserPos = this.transform.position;
		float rotationAngle = transform.localEulerAngles.z - 90;

		laserPos.x += (Mathf.Cos((rotationAngle) *
			Mathf.Deg2Rad) * -LaserDistance);
		laserPos.y += (Mathf.Sin((rotationAngle) *
			Mathf.Deg2Rad) * -LaserDistance);
		Instantiate(Laser, laserPos, this.transform.rotation);
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
