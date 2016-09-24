using UnityEngine;
using System.Collections;

public class playerBehaviour : MonoBehaviour {
	// Movement modifier applied to directional 
	//movement.
	public float playerSpeed = 4.0f;
	// What the current speed of our player is
	private float currentSpeed ;
	// The last movement that we've made
	private Vector3 lastMovement ;
	// Use this for initialization






	void Start () {
		//this.playerSpeed = 4.0f;
		this.currentSpeed = 0.0f;
		this.lastMovement = new Vector3 ();

	}
	
	// Update is called once per frame
	void Update () {
		Rotation ();
		Movement1 ();
	}

	private void Rotation(){

		Vector3 worldpos = Input.mousePosition;
		worldpos = Camera.main.ScreenToViewportPoint (worldpos);

		float dx = this.transform.position.x - worldpos.x;
		float dy = this.transform.position.y - worldpos.y;
		float angle = Mathf.Atan2 (dy, dx) * Mathf.Rad2Deg;

		Quaternion rot = Quaternion.Euler (new Vector3 (0, 0, angle + 90));

		this.transform.rotation = rot;

	}
	private void Movement1(){

		Vector3 movement = new Vector3 ();

		movement.x += Input.GetAxis ("Horizontal");
		movement.y += Input.GetAxis ("Vertical");
		movement.Normalize ();

		if (movement.magnitude > 0) {
			currentSpeed = playerSpeed;
			this.transform.Translate (movement * Time.deltaTime *
			playerSpeed, Space.World);
			lastMovement = movement;
		
		} else {
			this.transform.Translate (lastMovement * Time.deltaTime *
				currentSpeed, Space.World);
			currentSpeed *= .9f;
		}


	}

	private void Movement2(){
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Vector3 position = this.transform.position;
			position.x -= .5f;;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x += .5f;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.y += .5f;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Vector3 position = this.transform.position;
			position.y -= .5f;
			this.transform.position = position;
		}
			
	}

	private void Movement3()
	{
		//Object move = Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		//transform.position += move * playerSpeed * Time.deltaTime;
	}
}
