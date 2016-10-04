/**
 * This is a retro shooter game 
 * 
 * @FileName: LaserBehaviour.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 03-October-2016
 * @description: this file is LaserBehaviour cs file for the game
 */

using UnityEngine;
using System.Collections;


/**  
 * <summary>  
 * This is the LaserBehaviour class which defines how laser will behave.  
 * </summary>  
 *   
 * @class LaserBehaviour  
 */
public class LaserBehaviour : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLE+++++++++++++++++++++++++++++++++
	// Length of laser life
	public float LifeTime = 2.0f;
	// Laser movement speed
	public float Speed = 5.0f;
	// Number of damage one laser makes if it hit an enemy
	public int Damage = 1;

	//METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	/**
        * <summary>
        * This is the method for starting the laser behaviour class
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
	void Start () {
		Destroy(gameObject, LifeTime);
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
		transform.Translate(Vector3.up * Time.deltaTime * Speed);
	}



}
