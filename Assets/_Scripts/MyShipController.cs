using UnityEngine;
using System.Collections;

public class MyShipController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE+++++++++++++++++++
	private Transform _tranform;
	//private AudioSource[] Sounds;

	//PUBLIC INSTANCE VARIABLE++++++++++++++++++
	public AudioSource HitSound;
	public AudioSource PowerUpSound;
	public GameController gameController;


	// Use this for initialization
	void Start () {
	
		this._tranform = this.GetComponent<Transform> ();
		//this.Sounds = this.GetComponents<AudioSource> ();
		//this._hitSound = this.Sounds[1];
		//this._powerUpSound = this.Sounds[2];
	}
	
	// Update is called once per frame
	void Update () {
	
		//Input.mousePosition.x;

		this._tranform.position = new Vector2(Mathf.Clamp( Input.mousePosition.x-246f,-246f,246f) ,-170f);


	}

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
